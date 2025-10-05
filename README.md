Mini Trading Platform
Description

A simple console-based trading platform where users can:

Register and log in

Upload items for trade

View items and request trades

Accept or deny trade requests

View completed trades

All user data, items, and trade requests are saved and loaded from text files.

Files in the Project

Program.cs: Main program that runs the trading platform and handles user interaction.

Item.cs: Defines the Item class (represents an item for trade).

User.cs: Defines the User class (represents a user in the system).

TradeRequest.cs: Defines the TradeRequest class (represents a trade request between users).

DataStorage.cs: Saves and loads data to/from text files (users, items, trade requests).

Save.cs: Helper methods for saving and loading data.

Getting Started
Requirements

.NET SDK installed (for running the project).

Steps to Run:

Clone or download the project files to your computer.

Open the project folder in your IDE (e.g., Visual Studio or Visual Studio Code).

Build and run the project using the following command:

dotnet run

How to Use

Once the program is running, you'll see a menu with options to:

Register: Register a new user with a username and password.

Login: Log in to the system.

Logout: Log out of the system.

Upload Item: Add an item to the platform for trade.

View Items: View all the items available for trade.

Request Trade: Request to trade for an item.

View Trade Requests: View all trade requests you’ve made.

Accept Trade Request: Accept a trade request.

Deny Trade Request: Deny a trade request.

View Completed Trades: View trades that have been completed.

Exit: Exit the program.

Files Structure
/Inlämning
│
├── Program.cs          # Main entry point
├── Item.cs             # Item class
├── User.cs             # User class
├── TradeRequest.cs     # TradeRequest class
├── DataStorage.cs      # Data storage handling
└── Save.cs             # Helper methods for saving/loading data



