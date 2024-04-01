using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Amazing World of Pokemon!\n\nWould you like to:\n1. Start a new game.\n2. Continue game.");
        string choice = Console.ReadLine();
        List<Pokemon> allPokemon = SetupPokemon();
        List<Item> bag = SetupBag();
        string coolSymbols = "░▒▓ ▄▀ ";
        

        switch (choice) {
            case "1":
            Console.Write("What is your name? ");
            string trainerName = Console.ReadLine();
            Console.Write("Which Pokemon would you like as a starter?\n  1. Charmander\n  2. Squirtle\n  3. Bulbasaur\n\nEnter your option here: ");
            choice = Console.ReadLine();
            Pokemon starterPokemon = null;
            switch (choice) {
                case "1":
                starterPokemon = allPokemon[0];
                break;
                case "2":
                starterPokemon = allPokemon[1];
                break;
                case "3":
                starterPokemon = allPokemon[2];
                break;
            }
            List<Pokemon> pokeTeam = [starterPokemon];
            Trainer trainer = new Trainer(trainerName, pokeTeam, bag);
            Menu(trainer, allPokemon);
            break;
            case "2":
            break;
        }
    }

    static void Menu(Trainer trainer, List<Pokemon> allPokemon) {
        bool hasQuit = false;

        while (!hasQuit){

        
        Console.Clear();
        Console.Write("What would you like to do?\n  1. Enter the tall grass.\n  2. Heal at PokeCenter.\n  3. Save Game.\n  4. Quit.\nEnter your choice here: ");
        string choice = Console.ReadLine();
        

        switch (choice) {
            case "1":
            Battle(trainer, allPokemon);
            break;
            case "2":
            break;
            case "3":
            break;
            case "4":
            break;
        }
        }
    }

    static void Battle(Trainer trainer, List<Pokemon> allPokemon) {
        Console.Clear();
        Pokemon enemyPokemon = allPokemon[2];
        int enemyHP = enemyPokemon.GetHealth();
        int enemyCurrentHP = enemyPokemon.GetHealth();
        Pokemon trainerPokemon = trainer.GetPokemon();
        int pokeHP = trainerPokemon.GetHealth();
        int pokeCurrentHealth = trainerPokemon.GetCurrentHealth();
        


        Console.WriteLine("Whoa?");
            // Add encounter animation here eventually
            Console.WriteLine($"You encounter a wild {enemyPokemon.GetPokeName()}!");
            Thread.Sleep(1000);
            Console.WriteLine($"Go {trainerPokemon.GetPokeName()}!");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"                                                            {enemyPokemon.GetPokeName()}");
            Console.WriteLine($"                                                            :L{enemyPokemon.GetLevel()}");
            Console.WriteLine($"                                                            HP: {enemyCurrentHP}/{enemyHP}");
            Console.WriteLine($"{trainerPokemon.GetPokeName()}");
            Console.WriteLine($":L{trainerPokemon.GetLevel()}");
            Console.WriteLine($"HP: {pokeCurrentHealth}/{pokeHP}");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("[Fight]   [Pokemon]");
            Console.WriteLine("[Bag]     [Run]");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();

            switch (option.ToLower()) {
                case "fight":

                break;
                case "pokemon":
                break;
                case "bag":
                break;
                case "run":
                Console.WriteLine("\nYou got away safely.");
                Thread.Sleep(2000);
                Console.Clear();
                break;
            }

    }

    static List<Pokemon> SetupPokemon(){
        Type normal = new Type("normal", "fighting", "none");
        Type fire = new Type("fire", "water", "grass");
        Type water = new Type("water", "grass", "fire");
        Type grass = new Type("grass", "fire", "water");

        Move tackle = new Move("Tackle", 30, normal);
        Move ember = new Move("Ember", 40, fire);
        Move waterGun = new Move("Water Gun", 40, water);
        Move vineWhip = new Move("Vine Whip", 40, grass);

        List<Move> charMoveset = [tackle, ember];
        List<Move> squirtMoveset = [tackle, waterGun];
        List<Move> bulbMoveset = [tackle, vineWhip];

        Pokemon charmander = new Pokemon("Charmander", charMoveset, fire, 5, 19, 19, 11, 11, 12);
        Pokemon squirtle = new Pokemon("Squirtle", squirtMoveset, water, 5, 19, 19, 11, 11, 12);
        Pokemon bulbasaur = new Pokemon("Bulbasaur", bulbMoveset, grass, 5, 19, 19, 11, 11, 12);

        return [charmander, squirtle, bulbasaur];
    }

    static List<Item> SetupBag() {
        Potion potions = new Potion("Potion", "Heals 20 health.", 5, 20);
        Pokeball pokeballs = new Pokeball("Pokeball", "Has a 28% chance of catching a pokemon", 5, 28);
        return [potions, pokeballs];
    }


}