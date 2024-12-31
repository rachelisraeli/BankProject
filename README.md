# BankProject

## Introduction
BankProject is a backend application developed in C# using the .NET framework.
The project is designed to manage banking operations, including functionalities such as account management, transaction tracking, and more.
The project adheres to the SOLID design principles to ensure it is maintainable and scalable.

## SOLID Design Principles

The project follows the SOLID design principles:

- **Single Responsibility Principle (SRP):**
  Each class in the project has a single responsibility, ensuring that changes in one part of the system affect only that part.
- **Open/Closed Principle (OCP):**
  The system is designed to be extended with new functionality without modifying existing code, promoting reusability and robustness.
- **Liskov Substitution Principle (LSP):**
  The system ensures that derived classes can substitute their base classes without affecting the functionality, maintaining integrity and consistency.
- **Interface Segregation Principle (ISP):**
  The system uses specific, focused interfaces rather than general-purpose ones, ensuring that classes only implement methods they actually use.
- **Dependency Inversion Principle (DIP):**
  The system depends on abstractions rather than concrete implementations, promoting flexibility and reducing coupling between components.

## Installation
To set up the project locally, follow these steps:

1. Clone the repository:
  ```git clone https://github.com/rachelisraeli/BankProject.git```

2. Navigate to the project directory:
  ```cd BankProject```

3. Open the project in your preferred IDE (e.g., Visual Studio).
4. Restore the dependencies:
   ```
   dotnet restore
   ```

5. Build the project:
    ```
    dotnet build
    ```

## Usage

To run the project:

1. Start the application:
    ```
    dotnet run
    ```
2. The application will be hosted on `http://localhost:5000` by default.


## Contact
For any inquiries or issues, please contact @rachelisraeli.
