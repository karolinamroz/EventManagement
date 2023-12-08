# EventManagement

Prerequisites

1. Visual Studio 2022 or later
2. .net 6 SDK
3. SQL Server

How to run the project?

1. Run the PalomaTest.sln solution on your machine.
2. Check if the ConnectionString in the project corresponds with your local database in SQL Server (PalomaTestApp/appsettings.json).
3. In Visual Studio, open the Package Manager Console from the View menu -> Other Windows -> Package Manager Console. Enter the following command: update-database
4. Run the project using IIS Express.
