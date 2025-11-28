using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace ScanSpectre
{
    public class AddressScanner
    {
        private readonly string _host;
        private readonly int _timeout;
        private readonly SemaphoreSlim _threadLimiter;

        public AddressScanner(string host, int timeout, int maxThreads)
        {
            _host = host;
            _timeout = timeout;
            _threadLimiter = new SemaphoreSlim(maxThreads, maxThreads);
        }

        public async Task<ScanResult> ScanPortAsync(int port)
        {
            await _threadLimiter.WaitAsync();

            try
            {
                using TcpClient client = new();
                var connectTask = client.ConnectAsync(_host, port);
                var timeoutTask = Task.Delay(_timeout);

                var completed = await Task.WhenAny(connectTask, timeoutTask);

                return new ScanResult
                {
                    Port = port,
                    IsOpen = completed == connectTask && client.Connected
                };
            }
            finally
            {
                _threadLimiter.Release();
            }
        }
    }
}
