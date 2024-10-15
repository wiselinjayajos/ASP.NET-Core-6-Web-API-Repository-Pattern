# ASP.NET Core 6 Web API Boilerplate with Repository Pattern

This project is a boilerplate template for creating a Web API using ASP.NET Core 6. It implements the Repository Pattern and uses Entity Framework Core for data access. This template is designed as a starter point for any ASP.NET Core Web API project, providing a clean and modular codebase with sample data.

## Features
- **ASP.NET Core 6**: Leverages the latest features and improvements in ASP.NET Core 6.
- **Repository Pattern**: Provides a clean separation of concerns and makes it easy to swap out data storage methods.
- **Entity Framework Core**: Uses EF Core for data access, making it easy to query and manage data in a database.
- **Sample Data**: Includes sample data models and seed data for easy setup and testing.
- **Swagger Integration**: Pre-configured Swagger UI for API testing and documentation.

## Getting Started
Follow these instructions to get the project up and running:

## Prerequisites
- [.NET SDK 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or any compatible database (if using EF Core)

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/wiselinjayajos/ASP.NET-Core-6-Web-API-Repository-Pattern.git

2. Navigate to the project directory:
   ```bash
   cd ASP.NET-Core-6-Web-API-Repository-Pattern

3. Restore the packages:
   ```bash
   dotnet restore

4. Update the database (if using EF Core):
   ```bash
   dotnet ef database update

5. Run the application:
   ```bash
   dotnet run
   
The API will be accessible at https://localhost:5001 or http://localhost:5000.

## Project Structure
The project follows a modular structure:

- **Controllers**: API controllers for handling HTTP requests.
- **Repositories**: Interfaces and implementations for accessing data.
- **Services**: Business logic layer that interacts with repositories and is used by controllers to handle API requests.
- **Models**: Data models representing entities in the database.
- **Data**: This boilerplate is using sample data (static data).

## Usage
1. Customize the models, repositories, and controllers according to your project's requirements.
2. Update the connection string in appsettings.json to point to your database.
3. Use Swagger (/swagger/index.html) for testing and documentation.

## Contributing
Contributions are welcome! Feel free to open an issue or submit a pull request.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

### Support
If you find this project useful, consider supporting me by buying me a coffee! ☕
[<img src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" width="200">](https://www.buymeacoffee.com/wiselinjayjayajos)


