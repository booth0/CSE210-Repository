using System;

class Potion:Item {
    private int amountRestores;
    public Potion(string itemName, string itemDescription, int quantity, int amountRestores):base(itemName, itemDescription, quantity){
        this.amountRestores = amountRestores;
    }
}