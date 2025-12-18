# Social feed (Console App)

This project is a **.NET Console Application** designed to seed initial data for a Blog system using **Entity Framework Core**.

## 📌 Project Purpose

The main purpose of this application is to:
- Initialize the Blog database with sample data
- Seed users, posts, comments, and reactions
- Display basic statistics in the console after seeding

The project is intended for **development and testing environments** to quickly prepare a usable dataset.

## 🛠️ Technologies Used

- .NET (Console Application)
- C#
- Entity Framework Core
- SQL Database (via EF Core)

## 📂 Project Structure

### Structure Overview
- **Blog.Console**  
  Entry point of the application. Responsible for running the seeding process.

- **Blog.Domain**  
  Contains core domain entities and business rules.

- **Blog.Application**  
  Contains application logic and use cases.

- **Blog.Infrastructure**  
  Handles database access, EF Core configuration, and data seeding.

## ▶️ How It Works

1. The console application starts from `Program.cs`
2. The database context is initialized
3. Seed logic inserts initial data into the database
4. The application prints statistics such as:
   - Number of users
   - Number of posts
   - Number of comments
   - Number of reactions

## ▶️ How to Run

1. Ensure the database connection string is configured correctly
2. Apply database migrations (if required):
   ```bash
   dotnet ef database update


