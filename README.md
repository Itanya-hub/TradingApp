TradingWorldApp is a simple, command-line application built in C# that simulates an internal trading platform. Users can securely log in to view items posted by other users and retrieve contact information to facilitate real-world trades.

It uses fundamental C# concepts like:

Classes (User, Item)

Lists (List<User>, List<Item>)

Control Flow (while, if/else, foreach)

Simple Session Management (active_user variable)

 Default User Credentials
The application is pre-loaded with several users and their items. You can use these credentials to test the login and trading functionality:

User Email

Password

Owned Items

sliverlover@nbi.se (Nick)

Nick123

Silver rings

goldhunting@nbi.se (Lucas)

Lucas123

Gold and Pearl necklaces

finna@nbi.se (Brandon)

Brandon123

Silver wrist jewelry

jewelry@nbi.se (Dan)

Dan123

Pearl and Topaz earrings

thaisouvenir@nbi.se (Tanya)

Tanya123

Diamond and Amethyst bracelets

How to Use the App
The application operates entirely through the main console loop.

1. Login
Upon starting, you will be prompted to log in:

Enter one of the default Email addresses listed above.

Enter the corresponding Password.

If successful, the main menu will appear. If unsuccessful, you will receive a "Login failed" message.

2. Main Menu Options (Logged In)
Once logged in, the menu provides four options:

Option

Command

Description

1

Show all items

Displays a simple, unfiltered list of all items not owned by the currently active user.

2

Trade for an item

Lists available items (not owned by you) with numbered selections. After choosing an item number, the owner's email is provided for trade negotiation.

3

Log out

Clears the current session (active_user = null) and returns the user to the Login screen.

4

Exit program

Terminates the application loop (running = false) and closes the console window.
=======
TradingWorldApp is a simple, command-line application built in C# that simulates an internal trading platform. Users can securely log in to view items posted by other users and retrieve contact information to facilitate real-world trades.

It uses fundamental C# concepts like:

Classes (User, Item)

Lists (List<User>, List<Item>)

Control Flow (while, if/else, foreach)

Simple Session Management (active_user variable)

 Default User Credentials
The application is pre-loaded with several users and their items. You can use these credentials to test the login and trading functionality:

User Email

Password

Owned Items

sliverlover@nbi.se (Nick)

Nick123

Silver rings

goldhunting@nbi.se (Lucas)

Lucas123

Gold and Pearl necklaces

finna@nbi.se (Brandon)

Brandon123

Silver wrist jewelry

jewelry@nbi.se (Dan)

Dan123

Pearl and Topaz earrings

thaisouvenir@nbi.se (Tanya)

Tanya123

Diamond and Amethyst bracelets

How to Use the App
The application operates entirely through the main console loop.

1. Login
Upon starting, you will be prompted to log in:

Enter one of the default Email addresses listed above.

Enter the corresponding Password.

If successful, the main menu will appear. If unsuccessful, you will receive a "Login failed" message.

2. Main Menu Options (Logged In)
Once logged in, the menu provides four options:

Option

Command

Description

1

Show all items

Displays a simple, unfiltered list of all items not owned by the currently active user.

2

Trade for an item

Lists available items (not owned by you) with numbered selections. After choosing an item number, the owner's email is provided for trade negotiation.

3

Log out

Clears the current session (active_user = null) and returns the user to the Login screen.

4

Exit program
