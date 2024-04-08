using System;
using System.Reflection.Metadata.Ecma335;

public abstract class Item {
    protected string itemName;
    protected string itemDescription;
    protected int quantity;
    public Item(string itemName, string itemDescription, int quantity){
        this.itemName = itemName;
        this.itemDescription = itemDescription;
        this.quantity = quantity;
    }
    public void ItemDisplay() {
        Console.WriteLine($"  [{itemName}] x{quantity}: {itemDescription}");
    }
    public int Quantity {
        get { return quantity; }
        set { quantity = value; }
    }
    
    public abstract int ItemUse(int enemyCurrentHP, int enemyHP);
}