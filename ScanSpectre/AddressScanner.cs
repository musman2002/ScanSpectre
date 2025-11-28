using System;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace ScanSpectre
{
    public class AddressScanner
    {
        private readonly string host;
        private readonly int timeout;
        private readonly int threads;

        public event Action<ScanResult>? OnResult;
        public event Action<int>? OnCurrentPort;

        public AddressScanner(string host, int timeoutMs, int threadCount)
        {
            this.host = host;
            timeout = timeoutMs;
            threads = threadCount;
        }

        public async Task StartAsync(AddressList portRange)
        {
            SemaphoreSlim limiter = new SemaphoreSlim(threads);
            ConcurrentBag<Task> tasks = new();

            foreach (var port in portRange.Ports())
            {
                await limiter.WaitAsync();

                var t = Task.Run(async () =>
                {
                    try
                    {
                        OnCurrentPort?.Invoke(port);
                        bool open = await ScanPortAsync(host, port, timeout);
                        OnResult?.Invoke(new ScanResult { Port = port, IsOpen = open });
                    }
                    finally
                    {
                        limiter.Release();
                    }
                });

                tasks.Add(t);
            }

            await Task.WhenAll(tasks);
        }

        private async Task<bool> ScanPortAsync(string host, int port, int timeoutMs)
        {
            try
            {
                using TcpClient client = new();
                var connectTask = client.ConnectAsync(host, port);
                if (await Task.WhenAny(connectTask, Task.Delay(timeoutMs)) == connectTask)
                    return client.Connected;
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
