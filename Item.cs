//Represent a trade item
namespace App;

public class Item

{
    // These are the permanent Fields (PascalCase)
    public string ItemName;     // Name of item
    public User Owner = null!;    // Who owns this item 

    //  These are the temporary Parameters (camelCase)
    public Item (string itemName, User owner) 
    {
        // // Assignment: Permanent Field = Temporary Parameter
        this.ItemName = itemName;
        this.Owner = owner;
    }
}