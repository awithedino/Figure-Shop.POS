# FigureShop.POS

This project is a Point of Sale (POS) system for a figure shop, built with Windows Forms and .NET 8. It uses Entity Framework Core for data access and can be run with a SQL Server database hosted in a Docker container.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

*   [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
*   [Docker Desktop](https://www.docker.com/products/docker-desktop)
*   An IDE that supports .NET development, such as Visual Studio, JetBrains Rider, or VS Code.

### Setting up Docker

1.  **Start Docker Desktop:** Make sure Docker Desktop is running on your machine.
2.  **Run SQL Server Container:** Open a terminal or command prompt and run the following command to start a SQL Server container:

    ```bash
    docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=P@ssw0rd123" -p 1433:1433 --name sql_server_pos -d mcr.microsoft.com/mssql/server:2019-latest
    ```

3.  **Verify Container is Running:** You can check if the container is running with the following command:

    ```bash
    docker ps
    ```

    You should see `sql_server_pos` in the list of running containers.

### NuGet Packages

The following NuGet packages are used in this project:

*   `Microsoft.EntityFrameworkCore.Design`
*   `Microsoft.EntityFrameworkCore.SqlServer`
*   `Microsoft.Extensions.Hosting`
*   `ClosedXML`

These packages will be restored automatically when you build the project.

### Running the Application

1.  **Update Connection String:** Open the `appsettings.json` file and update the connection string to point to your SQL Server container. The default connection string should look like this:

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost,1433;Database=FigureShop;User Id=sa;Password=P@ssw0rd123;Trusted_Connection=False;Encrypt=False;"
      }
    }
    ```

2.  **Apply Migrations:** Open a terminal or command prompt in the project root directory and run the following command to apply the database migrations:

    ```bash
    dotnet ef database update
    ```

3.  **Run the Application:** You can now run the application from your IDE or by using the following command in the project root directory:

    ```bash
    dotnet run
    ```

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
