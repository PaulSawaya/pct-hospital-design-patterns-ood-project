# 🏥 PCT Hospital Management System

A Windows Forms (.NET Framework) desktop application that simulates hospital operations using object-oriented programming principles, SOLID design, and GoF design patterns. Built with an emphasis on extensibility, clarity, and maintainability.

---

## 📚 Project Overview

This project models a hospital management system that:
- Manages inpatients, outpatients, and visitors.
- Calculates and processes payments.
- Builds and displays hospital rooms.
- Exports data to an external hospital management system.

It utilizes multiple design patterns and follows the SOLID principles to ensure scalable, modular code.

---

## 🛠 Technologies Used

- **C# / .NET Framework**
- **Windows Forms (WinForms)**
- **OOP (Abstraction, Inheritance, Polymorphism)**
- **Design Patterns (GoF)**
- **SOLID Principles**

---

## 🎨 Key Features

- **Singleton Pattern**  
  Ensures only one instance of the `Hospital` exists using a private constructor and static accessor.

- **Builder Pattern**  
  Dynamically creates hospital rooms (Regular & First Class) with specific features using separate builder classes.

- **Adapter Pattern**  
  `HospitalManagementSystemConnector` adapts the internal system to work with an external `HospitalManagementSystem` that was incompatible by default.

---

## 🧠 SOLID Principles

| Principle             | Application in Project |
|----------------------|------------------------|
| Single Responsibility | Each class has one responsibility (e.g., `Receipt`, `Payment`, `Visitor`) |
| Open/Closed           | Easily add new patient types or payment modes without modifying existing classes |
| Liskov Substitution   | Subtypes like `InPatient` and `OutPatient` replace `Patient` without error |
| Interface Segregation | Separate interfaces for `IPatient`, `IVisitor`, and `IEntrants` |
| Dependency Inversion  | Uses abstractions (`SystemConnector`, `IReceipt`) instead of tight coupling |

---

## 🚀 How to Run the Project

1. Open `Visual Studio`.
2. Click **Open a project or solution**.
3. Navigate to `code/` and select the `OOD Proj Final.sln` file.
4. Click **Start** (`F5`) to run the application.
5. Use the UI buttons to trigger different functionalities like showing hospital info, displaying payment details, and exporting data.

---

## 📄 Documentation

- [✅ Project Report (PDF)](Documentation/Hospital_Report.pdf)
- [🧠 Class Diagram (StarUML)](Documentation/OOD_Paul_Tiana_Charbel.mdj)
