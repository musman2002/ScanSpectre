# ScanSpectre - TCP Port Scanner

**ScanSpectre** is a multi-threaded, Windows Forms-based TCP port scanner that allows users to scan a range of ports on a specified IP address or domain. This tool provides real-time feedback on open/closed port statuses and includes settings for adjusting scan parameters such as port range, timeout, and concurrent threads.

## Features

- **Scan by IP Address or Domain Name**
- **Define Port Range**: Specify start and end ports for scanning.
- **Set Connection Timeout**: Control how long each port attempt lasts.
- **Real-Time Port Status Updates**: Displays open/closed status in a grid.
- **Current Port Indicator**: Shows which port is currently being scanned.
- **Multi-Threaded Scanning**: Choose the number of concurrent threads for faster results.

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/ScanSpectre.git```
2. **Open the Project**: Open the project in Visual Studio or your preferred IDE.
3. **Build the Solution**: Build the solution to restore dependencies and compile the project.
4. **Run the Application**: Start the application from Visual Studio or by running the compiled executable.


## Usage
1. **Enter IP or Domain**: Input the IP address or domain to scan.
2. **Set Port Range:**:  Define the start and end ports for the scan.
3. **Set Timeout**:  Specify the timeout in milliseconds (default is 1000 ms).

4. **Click Start Scan**:  Begin scanning the selected port range.


- As the scan progresses, the status of each port (open or closed) will be displayed in the grid. The ```Current Port``` box will update to show the current port being scanned.

## Project Structure

- **ScanSpectre.cs**: Main form and UI code for the application.

- **ScanSpectre.Designer.cs**: UI layout and components setup.
- **AddressScanner.cs**: Core scanning logic for checking each port.
- **AddressList.cs**: Class representing the range of ports.

## Contributing
Contributions are welcome! Please submit issues or pull requests to help improve ScanSpectre.

## Disclaimer
**ScanSpectre** is intended for educational purposes and authorized scanning only. Ensure you have permission before scanning any network or IP address. Unauthorized port scanning may violate network policies or legal regulations.

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/musman2002/ScanSpectre/blob/master/LICENSE.txt) file for details.
