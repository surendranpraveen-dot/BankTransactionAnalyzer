# Bank Transaction Analyzer

## Overview
The Bank Transaction Analyzer is a sample ASP.NET MVC application designed to help users learn and demonstrate key concepts in web development, including LINQ, SQL Server integration, and the ASP.NET MVC architecture. This application simulates a banking environment, allowing users to analyze transactions and manage accounts.

## Tech Stack
- C#
- ASP.NET MVC
- LINQ
- SQL Server
- Docker
- Azure
- Kubernetes (AKS)

## Features
- **Transaction Management**: Create, view, and analyze bank transactions.
- **Account Management**: Manage bank accounts associated with transactions.
- **Data Visualization**: Display transaction data in a user-friendly format.

## Getting Started

### Prerequisites
- .NET SDK (version 5.0 or later)
- SQL Server
- Docker (for containerization)
- Azure account (for deployment)
- Kubernetes (for orchestration)

### Installation
1. Clone the repository:
   ```
   git clone https://github.com/microsoft/vscode-remote-try-dab.git
   cd bank-transaction-analyzer
   ```

2. Restore the dependencies:
   ```
   dotnet restore
   ```

3. Update the `appsettings.json` file with your SQL Server connection string.

4. Run the application:
   ```
   dotnet run
   ```

### Docker Setup
To build and run the application in a Docker container:
1. Build the Docker image:
   ```
   docker build -t bank-transaction-analyzer .
   ```

2. Run the Docker container:
   ```
   docker run -d -p 8080:80 bank-transaction-analyzer
   ```

### Deployment
For deploying the application to Azure Kubernetes Service (AKS), follow the Azure documentation for deploying .NET applications in containers.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.