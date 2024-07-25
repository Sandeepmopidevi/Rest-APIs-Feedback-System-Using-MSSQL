# Feedback System Using MSSQL

## Overview

**Feedback System Using MSSQL** is a straightforward RESTful API built with ASP.NET Core. It is designed to manage feedback records, utilizing Microsoft SQL Server (MSSQL) for structured and reliable data storage.

## Key Features

- **CRUD Operations**: Create, Read, Update, and Delete feedback entries.
- **MSSQL Integration**: Uses Microsoft SQL Server for robust data storage.
- **RESTful API**: Simple and effective endpoints for interacting with feedback data.

## API Endpoints

- **`GET /api/feedback`**: Retrieve all feedback entries.
- **`GET /api/feedback/{id}`**: Retrieve a feedback entry by ID.
- **`POST /api/feedback`**: Create a new feedback entry.
- **`PUT /api/feedback/{id}`**: Update an existing feedback entry by ID.
- **`DELETE /api/feedback/{id}`**: Delete a feedback entry by ID.

## Getting Started

### Prerequisites

- .NET SDK 6.0 or later
- Microsoft SQL Server or SQL Server Express

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/Sandeepmopidevi/feedback-system-mssql.git
   cd feedback-system-mssql
   ```

2. **Configure the Database**

   Update the `appsettings.json` file with your SQL Server connection string:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=FeedbackDB;Trusted_Connection=true;TrustServerCertificate=true;"
   }
   ```

3. **Apply Migrations**

   Run the following commands to apply database migrations:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Run the Application**

   ```bash
   dotnet run
   ```
### Usage

Use tools like [Postman](https://www.postman.com/) or [curl](https://curl.se/) to interact with the API. For example, to create a new feedback entry, send a POST request to `https://localhost:5001/api/feedback` with the following JSON body:

```json
{
    "name": "Sandeep",
    "email": "Sandeep@example.com",
    "phone": "123-456-7890",
    "comments": "Great service!",
    "rating": 5
}
```

### Contributing

Contributions are welcome! Please open an issue or submit a pull request to suggest improvements or report bugs.

### License

This project is licensed under the MIT License. See the file for details.

## Contact

For questions or feedback, please contact (mailto:asksandeep@example.com)
