# ATBM_AccessControl

# ATBM Access Control System

This project implements an access control system using Role-Based Access Control (RBAC) and Basic Access Control (BAC) in C# and Oracle. The system is designed to manage permissions for different roles within an organization such as Directors, Managers, Employees, and other custom roles. Each role has specific permissions to access and perform actions within the system, ensuring secure and efficient management of user access rights.

## Features
- **Role-Based Access Control (RBAC):** Assign and manage permissions based on predefined roles.
- **Basic Access Control (BAC):** Define and enforce basic access rules.
- **Role Hierarchies:** Support for creating hierarchical roles where higher-level roles inherit permissions from lower-level roles.
- **Custom Role Creation:** Create custom roles to fit specific organizational needs.
- **User Management:** Assign users to roles and manage their permissions.
- **Oracle Database Integration:** Store role and permission data securely using Oracle Database.

## Installation

### Prerequisites
- .NET Framework
- Oracle Database
- Visual Studio

### Steps
1. **Clone the repository:**
   ```sh
   git clone https://github.com/phamvuong2002/ATBM_AccessControl.git
   ```
2. **Open the project in Visual Studio.**
3. **Configure the Oracle database connection in the `app.config` file.**
4. **Run the database setup script** to create necessary tables and seed initial data.
5. **Build and run the project** to start the application.

## Usage
1. **Admin login:** Log in as an admin to manage roles and permissions.
2. **Assign roles:** Assign appropriate roles to users based on their position in the organization.
3. **Manage permissions:** Customize the permissions for each role as needed.

## Contributing
If you want to contribute to this project, feel free to fork the repository and submit a pull request.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact
For more information or support, please contact [Pham Vuong](mailto:your-email@example.com).
