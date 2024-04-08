using System;
using System.Diagnostics.Metrics;

class Pokemon {
    private string pokeName;
    private List<Move> moveset;
    Type pokeType;
    private int pokeLevel;
    private int health;
    private int currentHealth;
    private int attack;
    private int defense;
    private int speed;
    public Pokemon(string pokeName, List<Move> moveset, Type pokeType, int pokeLevel, int health, int currentHealth, int attack, int defense, int speed){
        this.pokeName = pokeName;
        this.moveset = moveset;
        this.pokeType = pokeType;
        this.pokeLevel = pokeLevel;
        this.health = health;
        this.currentHealth = currentHealth;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
    }

    public int CurrentHealth {
        get { return currentHealth; }
        set { currentHealth = value; }
    }

    public void DisplayPokemon() {
        Console.WriteLine($"[{pokeName}] :L{pokeLevel} {currentHealth}/{health}");
    }
    public string GetPokeName() {
        return pokeName;
    }
    public int GetLevel() {
        return pokeLevel;
    }
    public int GetHealth() {
        return health;
    }
    public int GetCurrentHealth() {
        return currentHealth;
    }
    public List<Move> GetMoves() {
        return moveset;
    }
     public int GetAttack() {
        return attack;
    }
     public int GetDefense() {
        return defense;
    }

    public Move DisplayMoves() {
        int counter = 1;
        foreach (Move move in moveset) {
            Console.WriteLine($"  {counter}. {move.GetName()}");
            counter += 1;
        }
        Console.Write("Which move would you like to use? ");
        int choice = int.Parse(Console.ReadLine());
        bool isCorrect = false;
        while (!isCorrect) {
            if (choice >= counter) {
                Console.WriteLine("Please choose one of the moves.");
                choice = int.Parse(Console.ReadLine());
            }
            else if (choice < counter) {
                isCorrect = true;
                
            }
            else {
                Console.WriteLine("Please enter a number.");
                choice = int.Parse(Console.ReadLine());
            }
        }
        return moveset[choice-1];
    }

    public Move RandomMove() {
        Random rnd = new Random();
        return moveset[rnd.Next(0, moveset.Count())]; 
        
    }

    public double WeakOrResists(Type moveType) {
        if (moveType.GetName() == pokeType.GetWeakness()) {
            Console.WriteLine("It's super effective!");
            return 4;
        }
        else if (moveType.GetName() == pokeType.GetResistance()) {
            Console.WriteLine("It's not very effective...");
            return 1.0;
        }
        else {
            return 2;
        }
    }
}