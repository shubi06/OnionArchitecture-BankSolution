# Bank Management System

## Overview
This project is a **Bank Management System** developed using **ASP.NET Core** following the **Onion Architecture** pattern. The system efficiently manages employees, departments, projects, locations, and allocations within a bank.

## Features
- Employee management with personal details and department association.
- Department structure with managers and project assignments.
- Project management linked to departments and office locations.
- Multiple bank office locations with assigned departments.
- Allocation system to track employee working hours per project.

## Architecture
This project follows the **Onion Architecture**, which enforces separation of concerns and dependency inversion. The main layers are:

### 1. **Domain Layer** (Core Business Logic)
   - Entities: `Employee`, `Department`, `Project`, `Location`, `Allocation`
   - Interfaces for repository patterns

### 2. **Application Layer** (Service Layer)
   - DTOs (Data Transfer Objects)
   - Service classes (`ProjectService`, `LocationService`, `AllocationService`, etc.)
   - Business rules and validation

### 3. **Infrastructure Layer** (Data Persistence)
   - Implementation of repositories with Entity Framework Core
   - Database configuration and migrations

### 4. **Presentation Layer** (API/Controllers)
   - REST API controllers for each entity
   - Swagger for API documentation

## Technologies Used
- **ASP.NET Core 8.0**
- **Entity Framework Core**
- **SQL Server**
- **Dependency Injection**
- **Swagger (Swashbuckle)**
- **Automapper**

## Getting Started
### Prerequisites
- .NET SDK (>=8.0)
- SQL Server
- Visual Studio / JetBrains Rider

### Installation Steps
1. **Clone the repository**
   ```sh
   git clone https://github.com/your-username/Bank-Management-System.git
   cd Bank-Management-System
   ```

2. **Configure the database** (update `appsettings.json` with your connection string)
   ```json
   {
       "ConnectionStrings": {
           "DefaultConnection": "Server=YOUR_SERVER;Database=BankDB;Trusted_Connection=True;"
       }
   }
   ```

3. **Apply database migrations**
   ```sh
   dotnet ef database update
   ```

4. **Run the application**
   ```sh
   dotnet run
   ```

5. **Access API documentation**
   Open Swagger UI: `http://localhost:5000/swagger`

## API Endpoints
| Resource     | Endpoint                    | Method |
|-------------|----------------------------|--------|
| Employees   | `/api/employees`           | GET    |
| Employees   | `/api/employees/{id}`      | GET    |
| Employees   | `/api/employees`           | POST   |
| Employees   | `/api/employees/{id}`      | PUT    |
| Employees   | `/api/employees/{id}`      | DELETE |
| Departments | `/api/departments`         | GET    |
| Projects    | `/api/projects`            | GET    |
| Locations   | `/api/locations`           | GET    |
| Allocations | `/api/allocations`         | GET    |

## Contribution
Contributions are welcome! Please follow these steps:
1. Fork the repository
2. Create a feature branch (`git checkout -b feature-name`)
3. Commit changes (`git commit -m 'Added feature X'`)
4. Push to branch (`git push origin feature-name`)
5. Open a pull request

## License
This project is licensed under the MIT License.

---

⭐ **Star this repo if you found it useful!** 🚀
