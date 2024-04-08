using System;

class Potion:Item {
    private int amountRestores;
    public Potion(string itemName, string itemDescription, int quantity, int amountRestores):base(itemName, itemDescription, quantity){
        this.amountRestores = amountRestores;
    }
    public override int ItemUse(int enemyCurrentHP, int enemyHP) {
        enemyCurrentHP += amountRestores;
        if (enemyCurrentHP > enemyHP) {
            return enemyHP;
        }
        return enemyCurrentHP;
    }
    public int GetHPRestored() {
        return amountRestores;
    }
}