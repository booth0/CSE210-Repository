using System;

class Pokeball:Item {
    private int percentCatch;
    public Pokeball(string itemName, string itemDescription, int quantity, int percentCatch):base(itemName, itemDescription, quantity){
        this.percentCatch = percentCatch;
    }
    
    

    public override int ItemUse(int enemyCurrentHP, int enemyHP) {
        int percentage;
        if (enemyCurrentHP/enemyHP * 100 <= 33) {
            percentage = percentCatch * 2;
        }
        else {
            percentage = percentCatch;
        }

        Random rnd = new Random();
        int number = rnd.Next(1, 100);
        if (number <= percentage){
            Console.WriteLine("The Pokemon was caught!");
            Thread.Sleep(700);
            return 1;
        }
        else {
            Console.WriteLine("The Pokemon broke free!");
            Thread.Sleep(700);
            return 0;
        }
        
    }
}