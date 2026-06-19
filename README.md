# Dental Clinic Manager

Dental Clinic Manager is a Windows Forms desktop application built in C# for managing the daily work of a dental clinic. It stores clinic data in SQL Server and provides separate modules for patients, appointments, billing, and dashboard reporting.
## Features

- Patient Management: Easily add, update, and track patient profiles and medical histories.
- Appointment Scheduling: Book, reschedule, and manage daily appointments for dentists.
- Treatment & Billing Tracker: Keep a record of dental treatments provided and automate invoice generation.
- Secure Database: Uses SQL Server to ensure data integrity, security, and quick search capabilities.
- Modern UI: Clean and responsive interface designed for clinic administrators and doctors.

---
## Project Information

- Course: Advanced Programming (COSC-5136)
- Semester: Spring 2026
- Project type: Semester project
- Application type: Windows Forms desktop application
- Database: SQL Server
- Data access: ADO.NET with `Microsoft.Data.SqlClient`



## Login Details

Use the following default credentials:

```text
Username: admin
Password: admin123
```

## Technologies Used

- C#
- .NET 9
- Windows Forms
- SQL Server
- ADO.NET
- Microsoft.Data.SqlClient
- WinForms.DataVisualization

## Project Structure

```text
DentalClinicManager/
|-- DentalClinicManager.slnx
|-- DentalClinicManager/
|   |-- Forms/
|   |   |-- frmLogin.cs
|   |   |-- MainDentalForm.cs
|   |   |-- PatientForm.cs
|   |   `-- Appointmentform .cs
|   |-- Views/
|   |   |-- Dashboardview .cs
|   |   |-- PatientView.cs
|   |   |-- Appointmentview .cs
|   |   `-- BillingView.cs
|   |-- Resources/
|   |-- App.config
|   `-- Program.cs
|-- DentalApp.core/
|   |-- Contracts/
|   |-- Models/
|   |-- Services/
|   `-- Utilities/
`-- images/
```

## Architecture

The project is separated into two main layers:

- `DentalClinicManager`: Windows Forms UI layer. It contains forms, user controls, resources, navigation, and screen events.
- `DentalApp.core`: Core application layer. It contains models, service interfaces, validation logic, and ADO.NET database services.

This separation keeps UI code separate from database and business logic.

## Database Configuration

The connection string is stored in:

```text
DentalClinicManager/App.config
```

Current database connection name:

```text
DentalClinicDB
```

Current connection string:

```text
Data Source=localhost;Initial Catalog=DentalClinicDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;
```

Create a SQL Server database named `DentalClinicDB` before running the project.

## Required Database Tables

The application expects these main tables:

### Patient

```sql
CREATE TABLE Patient (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(255) NOT NULL,
    CreatedAt DATETIME NOT NULL
);
```

### Appointment

```sql
CREATE TABLE Appointment (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PatientId INT NOT NULL,
    PatientName NVARCHAR(100) NOT NULL,
    Doctor NVARCHAR(100) NOT NULL,
    AppDate DATE NOT NULL,
    AppTime TIME NOT NULL,
    Treatment NVARCHAR(200) NOT NULL,
    Cost DECIMAL(18,2) NOT NULL,
    Status NVARCHAR(50) NOT NULL,
    Notes NVARCHAR(500) NULL,
    CreatedAt DATETIME NOT NULL
);
```

### Bills

```sql
CREATE TABLE Bills (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    AppointmentId INT NOT NULL,
    PatientId INT NOT NULL,
    PatientName NVARCHAR(100) NOT NULL,
    Treatment NVARCHAR(200) NOT NULL,
    Doctor NVARCHAR(100) NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Status NVARCHAR(50) NOT NULL,
    BillDate DATETIME NOT NULL
);
```

## How to Run

1. Install Visual Studio with .NET desktop development workload.
2. Install SQL Server or SQL Server Express.
3. Create a database named `DentalClinicDB`.
4. Create the required tables shown above.
5. Open `DentalClinicManager.slnx` in Visual Studio.
6. Restore NuGet packages if Visual Studio does not restore them automatically.
7. Confirm the connection string in `DentalClinicManager/App.config`.
8. Build and run the project.
9. Login with the default admin credentials.

## Rubric Requirements Covered

According to the project rubric, the important evaluation areas are:

- Project Setup & Architecture: The project uses a separated UI project and core project.
- Database & Connection: SQL Server connection is configured in `App.config`.
- Data Access Layer: ADO.NET services are implemented for patients, appointments, billing, and dashboard data.
- User Interface: Windows Forms navigation and CRUD screens are included.
- Validation & User Experience: Form validation, confirmation messages, and user feedback are included.
- Charting Module: Dashboard includes a chart for patient registrations over the last six months.
- Code Quality & Organization: Models, contracts, services, utilities, forms, and views are organized in separate folders.
- Demo & Viva: The project includes visible features that can be demonstrated module by module.

## Recommended / Bonus Features Included

- Search functionality in patients, appointments, and billing
- Dropdown filters for patient search fields, appointment status, and billing status
- Dashboard with summary statistics and chart on one screen
- Status bar showing the current section and date/time
- Record count labels for lists
- Async loading in the patient list using `GetAllAsync`
- Column sorting in DataGridView screens by clicking column headers
- Loading state in the patient list while data is being loaded

## Main Viva Points

During viva, explain these parts clearly:

- How the project is divided into UI and core layers
- How `App.config` provides the SQL Server connection string
- How service classes use ADO.NET commands and parameters
- How patient, appointment, and billing CRUD operations work
- How validation is handled before saving data
- How completing an appointment creates a bill
- How dashboard counts and chart data are loaded from the database
- How search filters records in the list screens

## Notes

- The project must be run on Windows because it uses Windows Forms.
- SQL Server must be available before testing CRUD operations.
- If the database name or server is different, update the connection string in `App.config`.
