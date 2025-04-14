GreenSwap: A Community Plant Exchange
GreenSwap is a desktop application that facilitates the exchange of houseplants within a community. Users can register plants for trade, browse offerings from others, arrange exchanges, and share growing tips.
Project Overview
This application was developed as part of CS665 Database Management Systems course. It demonstrates the implementation of a relational database system using SQLite with a C# Windows Forms front-end.
Features

User Management: Register, view, update, and delete user profiles
Plant Management: Add, view, update, and delete plant listings
Trade System: Request, accept, complete, and track plant trades between users
Plant Care Information: Store and access care information for different plant types
Advanced Queries: Find plants by location, type, availability, and more

Technology Stack

Database: SQLite (lightweight, serverless database)
Programming Language: C# (.NET 9.0)
UI Framework: Windows Forms with MaterialSkin.2
ORM: Entity Framework Core
Additional Libraries:

Bogus (for generating test data)
System.Data.SqlClient (for database connectivity)



Database Schema
The database consists of four main tables, each normalized to Third Normal Form (3NF):
Users Table

UserID (INTEGER, Primary Key, Auto-increment)
Username (TEXT, Unique, Not Null)
Email (TEXT, Unique, Not Null)
PasswordHash (TEXT, Not Null)
JoinDate (DATETIME, Not Null)
Location (TEXT, Not Null)
ProfileDescription (TEXT)

Plants Table

PlantID (INTEGER, Primary Key, Auto-increment)
UserID (INTEGER, Foreign Key references Users(UserID), Not Null)
PlantName (TEXT, Not Null)
PlantType (TEXT, Not Null)
Description (TEXT)
AgeOrStage (TEXT)
DateListed (DATETIME, Not Null)
Status (TEXT, Not Null, Default 'Available')

Trades Table

TradeID (INTEGER, Primary Key, Auto-increment)
RequestorID (INTEGER, Foreign Key references Users(UserID), Not Null)
ProviderID (INTEGER, Foreign Key references Users(UserID), Not Null)
PlantID (INTEGER, Foreign Key references Plants(PlantID), Not Null)
RequestDate (DATETIME, Not Null)
Status (TEXT, Not Null, Default 'Pending')
CompletionDate (DATETIME)
TradeNotes (TEXT)

PlantCareInfo Table

InfoID (INTEGER, Primary Key, Auto-increment)
PlantTypeName (TEXT, Unique, Not Null)
WateringFrequency (TEXT, Not Null)
LightRequirements (TEXT, Not Null)
SoilPreferences (TEXT)
DifficultyLevel (INTEGER, Not Null)
GrowthHabits (TEXT)
CommonIssues (TEXT)

Entity-Relationship Diagram
                        +-------------+
                        |    Users    |
                        +-------------+
                        | PK: UserID  |
                        +-------------+
                               |
                               | 1:N
                 +-------------+-------------+
                 |                           |
          +------v------+             +------v------+
          |    Plants   |             |   Trades    |
          +-------------+             +-------------+
          | PK: PlantID |<---------N:1| PK: TradeID |
          | FK: UserID  |             | FK: RequestorID (Users) |
          +-------------+             | FK: ProviderID (Users)  |
                 |                    | FK: PlantID (Plants)    |
                 | N:1                +-------------+
                 |                        
        +--------v--------+          
        | PlantCareInfo   |          
        +-----------------+          
        | PK: InfoID      |          
        | PlantTypeName   |           
        +-----------------+
Installation Instructions

Clone this repository to your local machine
Open the solution file GreenSwap.sln in Visual Studio 2022 or later
Restore NuGet packages (should happen automatically)
Build the solution
Run the application

Sample Queries
The application demonstrates several complex SQL queries:

Finding users with available plants:

sqlSELECT u.UserID, u.Username, u.Location, COUNT(p.PlantID) AS AvailablePlants
FROM Users u
JOIN Plants p ON u.UserID = p.UserID
WHERE p.Status = 'Available'
GROUP BY u.UserID, u.Username, u.Location
ORDER BY AvailablePlants DESC;

Finding plants by owner location:

sql
SELECT p.PlantID, p.PlantName, p.PlantType, p.Status, u.Username, u.Location
FROM Plants p
JOIN Users u ON p.UserID = u.UserID
WHERE u.Location LIKE '%{searchLocation}%'
AND p.Status = 'Available';

Finding the most popular plant types based on trade count:

sql
SELECT pci.PlantTypeName, pci.DifficultyLevel, COUNT(t.TradeID) AS CompletedTrades
FROM PlantCareInfo pci
LEFT JOIN Plants p ON pci.PlantTypeName = p.PlantType
LEFT JOIN Trades t ON p.PlantID = t.PlantID AND t.Status = 'Completed'
GROUP BY pci.PlantTypeName, pci.DifficultyLevel
HAVING CompletedTrades > 0
ORDER BY CompletedTrades DESC;

Screenshots
![Main Form](screenshots/main_form.png)
![User Management](screenshots/user_management.png)
![Plant Management](screenshots/plant_management.png)
![Trade Management](screenshots/trade_management.png)
![Plant Care Info](screenshots/plant_care_info.png)

License
This project is created for educational purposes as part of CS665 coursework.
Author
Vy Vo
Acknowledgments

Professor HuaBo Lu for guidance and instruction
MaterialSkin.2 library for the modern UI components
Entity Framework Core for ORM functionality
