using System;
using System.Xml.Serialization;

class Trainer {
    private string trainerName;
    private List<Pokemon> pokeTeam;
    private List<Item> bag;
    public Trainer(string trainerName, List<Pokemon> pokeTeam, List<Item> bag){
        this.trainerName = trainerName;
        this.pokeTeam = pokeTeam;
        this.bag = bag;
    }

    public List<Pokemon> PokeTeam {
        get { return pokeTeam; }
        set { pokeTeam = value; }
    }

    public Pokemon GetPokemon() {
        return pokeTeam[0];
    }

    public List<Pokemon> Healing() {
        foreach (Pokemon pokemon in pokeTeam) {
            pokemon.CurrentHealth = pokemon.GetHealth();
        }
        Console.WriteLine("Welcome to our Pokémon Center!");
        Thread.Sleep(700);
        Console.WriteLine("We heal your Pokémon back to perfect health!");
        Thread.Sleep(700);
        Console.WriteLine("Your Pokémon are now fighting fit!");
        Thread.Sleep(700);
        Console.WriteLine("We hope to see you again!");
        Thread.Sleep(700);
        return pokeTeam;
    }
    public void DisplayTeam() {
        foreach (Pokemon pokemon in pokeTeam) {
            pokemon.DisplayPokemon();
        }
    }
    public void BattleEndHealth(int pokeCurrentHealth) {
        pokeTeam[0].CurrentHealth = pokeCurrentHealth;
    }

    public int Bag(int enemyCurrentHP, int enemyHP) {
        foreach (Item item in bag) {
            item.ItemDisplay();
        }
        Console.WriteLine("  [Exit]");

        bool isUsed = false;
        while (!isUsed) {
            Console.Write("Which item would you like to use? ");
            string choice = Console.ReadLine();
            switch (choice.ToLower()){
                case "pokeball":
                if (bag[1].Quantity > 0) {
                bag[1].Quantity -= 1; 
                return bag[1].ItemUse(enemyCurrentHP, enemyHP);
                }
                else{
                    Console.WriteLine("Out of Pokeballs.");
                    isUsed = false;
                    break;
                }

                case "potion":
                if (bag[0].Quantity > 0) {
                bag[0].Quantity -= 1; 
                return bag[0].ItemUse(enemyCurrentHP, enemyHP);
                }
                else{
                    Console.WriteLine("Out of Potions.");
                    isUsed = false;
                    break;
                }

                case "exit":
                isUsed = true;
                break;

                default:
                Console.WriteLine("Invalid response.");
                isUsed = false;
                break;
        }
        }
        return 0;
    }

    public List<Pokemon> CaughtPokemon(Pokemon enemyPokemon) {
        pokeTeam.Add(enemyPokemon);
        return pokeTeam;
    }
}