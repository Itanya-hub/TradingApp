using App; // We import our own classes (User, Item)


//Create and store User objects in variables 
User nick = new User("sliverlover@nbi.se", "Nick123");
User lucas = new User("goldhunting@nbi.se", "Lucas123");
User brandon = new User("finna@nbi.se", "Brandon123");
User dan = new User("jewelry@nbi.se", "Dan123");
User tanya = new User("thaisouvenir@nbi.se", "Tanya123");


// All users login info
List<User> users = new List<User>();   
// 2. Add the stored User variables to the list
users.Add(nick);
users.Add(lucas);
users.Add(brandon);
users.Add(dan);
users.Add(tanya);


// All items for trade
List<Item> items = new List<Item>();
items.Add(new Item("sliver ring, ruby", nick));
items.Add(new Item("gold ring, ruby", nick));

items.Add(new Item("gold necklace", lucas));
items.Add(new Item("pearl necklace", lucas));

items.Add(new Item("sliver man wrist", brandon));
items.Add(new Item("sliver lady wrist", brandon));

items.Add(new Item("pearl earrings", dan));
items.Add(new Item("topaz earrings", dan));

items.Add(new Item("diamond bracelet", tanya));
items.Add(new Item("amethyst bracelet", tanya));



User? active_user = null ; // The person currently logged in
bool running = true;      // Control program loop

while (running)
{
    Console.Clear();

    if (active_user != null)
    {
        // Authorized menu
        Console.WriteLine($"Welcome {active_user.Email} to TradingWorldApp!");
        Console.WriteLine("1. Show all items");
        Console.WriteLine("2. Trade for an item");
        Console.WriteLine("3. Log out");
        Console.WriteLine("4. Exit program");
        string? input = Console.ReadLine();
    }
    else
    {

        Console.WriteLine("Sorry ,This trading app is for the member");
        string? choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Items available for trade:");
            foreach (Item item in items)
            {
                if (item.Owner.Email != active_user.Email)  // List only items not owned by the active user after login
                {
                    Console.WriteLine($"{item.ItemName} (Owner: {item.Owner.Email})");
                    Console.ReadLine();
                }
            }

        }
        else if (choice == "2")
        {
            List<Item> tradableItems = new List<Item>();
            Console.WriteLine("--- Select an Item to Trade For ---");
            int index = 1; //

            //loop for trading
            foreach (Item item in items)
            {
                if (item.Owner!.Email != active_user!.Email)

                {
                    Console.WriteLine($"{index}. {item.ItemName} (Owner: {item.Owner!.Email})");
                    tradableItems.Add(item); // Store the item for selection later
                    index++; // Increment the number for the next item
                }
            }
            // Handle case where user owns all items
            if (tradableItems.Count == 0)
            {
                Console.WriteLine("No items are currently available for trade.");
                Console.ReadLine();
                return;
            }
            //Ask user for their choice and provide contact info
            Console.Write("\nEnter the number of the item you want to trade for: ");
            string? tradeChoice = Console.ReadLine();

            if (int.TryParse(tradeChoice, out int itemNumber) &&
                itemNumber >= 1 && itemNumber <= tradableItems.Count)
            {
                // Get the selected item (index - 1 because List is 0-indexed)
                Item selectedItem = tradableItems[itemNumber - 1];

                Console.WriteLine($"\n--- Contact Information for {selectedItem.ItemName} ---");
                Console.WriteLine($"Owner: {selectedItem.Owner.Email}");
                Console.WriteLine("\nPlease copy the owner's email and contact them outside of this application to negotiate a trade.");
            }
            else
            {

                Console.WriteLine("\nInvalid selection.");
                Console.ReadLine(); // Pause before returning to menu

            }


        }

        // For log out


        // else if (choice == "3")
        // {
        //     active_user = null;
        // }

        // //For exit program
        // else if (choice == "4")
        // {
        //     running = false; // exit program
        //                      //END of the 'if (active_user != null)' block

        // }

        // //  This block runs ONLY if active_user == null
        // else
        // {
        //     Console.WriteLine("Please log in:");
        //     Console.Write("Email: ");
        //     string? email = Console.ReadLine();

        //     Console.Write("Password: ");
        //     string? password = Console.ReadLine();

        //     // foreach (User user in users)
        //     // {
        //     //     if (user.TryLogin(email!, password!))
        //     //     {
        //     //         active_user = user;
        //     //         break;
        //     //     }
        //     // }

        //     if (active_user == null)
        //     {
        //         Console.WriteLine("Login failed. Try again.");
        //         Console.ReadLine();
        //         //END of the 'while (running)' loop
        //     }
        // }

    }
    
}

        


        
            

