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

