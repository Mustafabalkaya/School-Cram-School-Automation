# A Tutorial Center Automation System Developed with ASP.NET MVC

This project is a student and staff management system developed using ASP.NET MVC. It utilizes Microsoft SQL Server Management Studio for the database design. The system includes functionalities for student and staff listing, adding, deleting, and updating. User roles and permissions are implemented, allowing users with different roles to access different screens.

## Features

- **Login Screen:** A screen has been created for users to log in, and the login process is executed using information retrieved from the database.

- **User Roles:** A class named "Roles" is created to define user roles. For instance, users with an admin role have access to everything, while users with a producer role can only access specific screens.

- **Student Management:** Operations for listing, adding, deleting, and updating students are implemented. When a new student is added, they are automatically added to the debts table, and the system updates debts as they are paid.

- **Class Capacity Control:** The class capacity is set to 40, and when a new student is added, one seat is subtracted from the class capacity, keeping track of available seats.

- **Student List by Department:** Student information is retrieved and displayed in a list using dropdown lists for numerical, verbal, equal-weight, and language classes.

- **Logout Process:** An action result for logging out is implemented, allowing users to securely exit the system without closing the browser.

## Technologies

- ASP.NET MVC
- Microsoft SQL Server Management Studio
- HTML, CSS, JavaScript

## Installation

1. Download the project to your computer.
2. Open the project using Visual Studio or a similar IDE.
3. Run the database script in Microsoft SQL Server Management Studio to create the database.

    ```sql
    -- Your SQL Script for creating tables and schema
    ```

4. Open Package Manager Console in Visual Studio.

    ```bash
    PM> Update-Database
    ```

    This will apply any pending migrations and update the database schema.

5. Run the project.

