// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using Inlämning;

    



bool running = true; // Correct declaration
User currentUser = null;  // Track logged-in user
    // storing all user inputs
    List <User> users = new List<User>();
    List<Item> items = new List<Item>();
            List<string> tradeRequests = new List<string>();  // List of trade requests
        List<string> completedTrades = new List<string>();  // List to track completed trades

     void Main(string[] args)
{
    bool running = true;
}

//main loop of program

    while (running)
    {

    Console.WriteLine("=== MIni Trading Platform ===");
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Logout");
    Console.WriteLine("4. UploadItem");
    Console.WriteLine("5. ViewItems");
    Console.WriteLine("6. Request Trade");
    Console.WriteLine("7. View Trade Requests");
    Console.WriteLine("8. Accept Trade Request");
    Console.WriteLine("9. Deny Trade Request");
    Console.WriteLine("10. View Completed Trades");
    Console.WriteLine("11. Exit");
    Console.WriteLine("Choose an Option");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Register();
            break;
        case "2":
            Login();
            break;
        case "3":
            Logout();
            break;
        case "4":
            UploadItem();
            break;
        case "5":
            ViewItems();
            break;
        case "6":
             RequestTrade();
            break;
        case "7":
            ViewTradeRequests();
            break;
        case "8":
            AcceptTradeRequest();
            break;
        case "9":
            DenyTradeRequest();
            break;
        case "10":
            ViewCompletedTrades();
            break;
            case "11":
                    running = false;  // Set the running flag to false, ending the loop
                    Console.WriteLine("Goodbye! Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid Option, try again.");
                    break;


    }

}

 void Register()
{
    Console.WriteLine("Enter Username:");
    string Username = Console.ReadLine();
    Console.WriteLine("Enter Password:");
    string password = Console.ReadLine();
    Console.WriteLine($"User '{Username}' registered succesfully!");
 }

 void Login()
{
    Console.Write("Enter Username to login: ");
    string username = Console.ReadLine();
    if (username.Contains(username))
    {
        Console.WriteLine($"User '{username}'logged in succesfully!");
    }

    else
    {
        Console.WriteLine("User not found. Please register first.");
    }
    
}


    void Logout()
{
    bool running = false;
    Console.WriteLine("You have been succesfully logged out");
}
      void UploadItem()
{
    Console.WriteLine("Enter Item Name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter item description");
    string description = Console.ReadLine();
    Console.WriteLine("Enter owner email");
    string owner = Console.ReadLine();
    Item itemToAdd = new Item(name, description, owner);
    items.Add(itemToAdd);
    Console.WriteLine("Item has been succesfully added!");
    }

    // View all items
     void ViewItems()
    {
        Console.WriteLine("=== All Items ===");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name} (Owner: {item.Owner})");
        }
    }

    // Request Trade
     void RequestTrade()
    {
        if (currentUser == null)
        {
            Console.WriteLine("Please log in first.");
            return;  // Return if no user is logged in
        }

        Console.Write("Enter the name of the item you want to trade for: ");
        string itemName = Console.ReadLine();
        tradeRequests.Add(itemName);
        Console.WriteLine($"Trade request for item '{itemName}' sent successfully!");
    }

    // View Trade Requests
     void ViewTradeRequests()
    {
        Console.WriteLine("=== Trade Requests ===");
        foreach (var request in tradeRequests)
        {
            Console.WriteLine(request);
        }
    }

    // Accept a trade request
     void AcceptTradeRequest()
    {
        if (currentUser == null)
        {
            Console.WriteLine("Please log in first.");
            return;  // Return if no user is logged in
        }

        Console.Write("Enter the name of the item you want to accept trade for: ");
        string itemName = Console.ReadLine();

        // Check if the trade request exists
        if (tradeRequests.Contains(itemName))
        {
            tradeRequests.Remove(itemName);
            completedTrades.Add(itemName);
            Console.WriteLine($"Trade request for '{itemName}' accepted!");
        }
        else
        {
            Console.WriteLine("Trade request not found.");
        }
    }

    // Deny a trade request
     void DenyTradeRequest()
    {
        if (currentUser == null)
        {
            Console.WriteLine("Please log in first.");
            return;  // Return if no user is logged in
        }

        Console.Write("Enter the name of the item you want to deny trade for: ");
        string itemName = Console.ReadLine();

        // Check if the trade request exists
        if (tradeRequests.Contains(itemName))
        {
            tradeRequests.Remove(itemName);
            Console.WriteLine($"Trade request for '{itemName}' denied.");
        }
        else
        {
            Console.WriteLine("Trade request not found.");
        }
    }

     // View completed trades
     void ViewCompletedTrades()
    {
        Console.WriteLine("=== Completed Trades ===");
        foreach (var trade in completedTrades)
        {
            Console.WriteLine(trade);
        }
    }




        
    


      
    




 


    





