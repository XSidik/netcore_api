# netcore_api & store procedure
my first api with netcore and store procedure (for learning)
## Overview
This project is a basic CRUD API built with .NET Core. It uses SQL Server as the database and leverages stored procedures for database operations.

## Features
- Create, Read, Update, Delete (CRUD) operations
- SQL Server database integration
- Use of stored procedures for database interactions

## Prerequisites
- .NET Core SDK:3.1
- SQL Server:2022

## Getting Started
1. Clone the repository:
    ```sh
    git clone https://github.com/XSidik/netcore_api.git
    ```
2. Navigate to the project directory:
    ```sh
    cd netcore_api
    ```
3. Run docker-compose to start sqlserver
    ```bash
    docker-compose -f docker/docker-compose-sqlserver.yml up --build
    ```    
   you can open the database use another app like dbeaver  
   create new DB with name:netcore_api  
   now, you can run all the sql query from the folder Database


## Running the Application
1. Run the project:
    ```sh
    docker-compose -f docker/docker-compose.yml up --build
    ```

## Using the API
The API exposes the following endpoints:
- `GET /api/Employee` - Retrieve all Employee
- `GET /api/Employee/{id}` - Retrieve an Employee by ID
- `POST /api/Employee` - Create a new Employee
- `PUT /api/Employee/{id}` - Update an existing Employee
- `DELETE /api/Employee/{id}` - Delete an Employee
