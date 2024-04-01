using System;

class Item {
    private string itemName;
    private string itemDescription;
    private int quantity;
    public Item(string itemName, string itemDescription, int quantity){
        this.itemName = itemName;
        this.itemDescription = itemDescription;
        this.quantity = quantity;
    }
}