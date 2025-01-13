# Cinema Booking System

## Overview
The Cinema Booking System is a Windows Forms application developed in .NET 8. It provides an intuitive interface for managing cinema bookings, including features for customers, screenings, and seat reservations. This application is designed to streamline the process of booking and managing cinema seats efficiently.

---

## Features
- **Customer Management**
  - Add, edit, and remove customers.
  - View customer details.
  
- **Seat Booking**
  - Select available seats for a specific screening.
  - Book seats with real-time updates to seat availability.
  
- **Screening Management**
  - Display available screenings.
  - Link bookings to specific screenings.

- **User-Friendly Interface**
  - Responsive and easy-to-navigate Windows Forms design.
  - Clear notifications and error messages for invalid inputs.

---

## Technologies Used
- **Framework:** .NET 8
- **UI Technology:** Windows Forms
- **Data Storage:** Initial random data is generated when the application starts. Data is serialized and saved to XML files when the app closes. Upon reopening, the data is loaded from these XML files.
- **Language:** C#

---

## Installation
### Prerequisites
- Ensure .NET 8 SDK is installed. You can download it from [Microsoft's .NET website](https://dotnet.microsoft.com/).
- Compatible with Windows operating systems.

### Steps
1. Clone the repository:
   git clone https://github.com/your-repo-name/cinema-booking-system.git


2. Navigate to the project folder:
   cd CinemaBoookingSystem

3. Build the project
    dotnet build

4. Run the application:
    dotnet run


## Project Structure

### 1. **CinemaBookingSystem**
- **Purpose**: This is the main application project where the Windows Forms UI is implemented.
- **Key Files**:
  - `Program.cs`: The entry point of the application.
  - `Dashboard.cs`: Contains the Windows Form UI logic for interacting with the cinema booking system.

---

### 2. **CinemaBookingSystem.Data**
- **Purpose**: Contains the core data model and business logic for the application.
- **Key Directories & Files**:
  - **`Data` Directory**: Includes serialized XML files for storing application data, such as customers, movies, screenings, and bookings.
  - **`Model` Directory**: Contains the core domain classes:
    - `Booking.cs`: Represents a booking made by a customer for a specific seat in a screening.
    - `Customer.cs`: Represents a customer in the system.
    - `Movie.cs`: Represents a movie in the system.
    - `Screen.cs`: Represents cinema screens where movies are shown.
    - `Screening.cs`: Represents scheduled screenings of movies.
    - `Seat.cs`: Represents an individual seat in a cinema screen.

---

### 3. **CinemaBookingSystem.Tests**
- **Purpose**: Contains automated unit tests for the application using the **NUnit** testing framework.
- **Key Files**:
  - `DatabaseTests.cs`: Includes tests for validating the behavior of the `Database` class, such as creating customers, making bookings, and deleting data.

---

## Running the Tests

### Prerequisites
- Ensure you have **Visual Studio** installed with the following workloads:
  - `.NET Desktop Development`
  - **NUnit Test Adapter** extension installed via the Visual Studio Marketplace or NuGet.
- **NUnit** must be installed in the `CinemaBookingSystem.Tests` project.

### Steps to Run the Tests
1. Open the solution in Visual Studio.
2. Navigate to the **Test Explorer**:
   - From the top menu, go to `Test > Test Explorer`.
3. Build the solution to load the test methods in the `Test Explorer`.
4. Run the tests:
   - You can run individual tests by right-clicking them in the Test Explorer and selecting `Run`.
   - Alternatively, run all the tests by clicking `Run All`.

---

## Notes on Testing
- The tests in `DatabaseTests.cs` cover the following scenarios:
  1. Validating customer creation and input validation.
  2. Booking a screening and ensuring the `Bookings` collection updates correctly.
  3. Canceling bookings and verifying the changes in data.
  4. Ensuring that serialized and deserialized data retains integrity.
- You can expand the test coverage by adding tests for edge cases and invalid inputs.