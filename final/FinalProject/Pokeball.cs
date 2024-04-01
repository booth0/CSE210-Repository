using System;

class Pokeball:Item {
    private int percentCatch;
    public Pokeball(string itemName, string itemDescription, int quantity, int percentCatch):base(itemName, itemDescription, quantity){
        this.percentCatch = percentCatch;
    }
}