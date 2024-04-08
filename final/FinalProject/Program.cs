using System;
using System.Reflection.Metadata;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("Welcome to the Amazing World of Pokemon!");
        List<Pokemon> allPokemon = SetupPokemon();
        List<Item> bag = SetupBag();
        // string coolSymbols = "░▒▓ ▄▀ ";
        
        Console.Write("What is your name? ");
        string trainerName = Console.ReadLine();
        Console.Clear();
        Console.Write($"{trainerName}, which Pokemon would you like as a starter?\n  1. Charmander\n  2. Squirtle\n  3. Bulbasaur\nEnter your option here: ");
        string choice = Console.ReadLine();
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
    }

    static void Menu(Trainer trainer, List<Pokemon> allPokemon) {
        bool hasQuit = false;

        while (!hasQuit){

        
        Console.Clear();
        Console.Write("What would you like to do?\n  1. Enter the tall grass.\n  2. Heal at PokeCenter.\n  3. View team.\n  4. Quit.\nEnter your choice here: ");
        string choice = Console.ReadLine();
        

        switch (choice) {
            case "1":
            trainer = Battle(trainer, allPokemon);
            break;
            case "2":
            Console.Clear();
            trainer.PokeTeam = trainer.Healing();
            break;
            case "3":
            Console.Clear();
            trainer.DisplayTeam();
            Console.Write("Press enter to continue: ");
            Console.ReadKey();
            break;
            case "4":
            Console.Clear();
            Console.WriteLine("Thank You for playing!");
            hasQuit = true;
            break;
        }
        }
    }

    static Trainer Battle(Trainer trainer, List<Pokemon> allPokemon) {
        Console.Clear();
        Random rnd = new Random();
        int number = rnd.Next(0, 2);
        Pokemon enemyPokemon = allPokemon[number];
        int enemyHP = enemyPokemon.GetHealth();
        int enemyCurrentHP = enemyPokemon.GetHealth();
        Pokemon trainerPokemon = trainer.GetPokemon();
        int pokeHP = trainerPokemon.GetHealth();
        int pokeCurrentHealth = trainerPokemon.GetCurrentHealth();
        bool battleEnded = false;
        Move currentMove;

        Console.WriteLine("Whoa?");
        // Add encounter animation here eventually
        Console.WriteLine($"You encounter a wild {enemyPokemon.GetPokeName()}!");
        Thread.Sleep(1000);
        Console.WriteLine($"Go {trainerPokemon.GetPokeName()}!");
        Thread.Sleep(1000);

        while (!battleEnded){
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
                currentMove = trainerPokemon.DisplayMoves();
                Console.WriteLine($"{trainerPokemon.GetPokeName()} used {currentMove.GetName()}!");
                Thread.Sleep(700);
                enemyCurrentHP = enemyCurrentHP - currentMove.CalculateDamage(enemyPokemon, trainerPokemon);
                Thread.Sleep(700);
                break;

                case "pokemon":
                trainer.DisplayTeam();

                break;

                case "bag":
                    int bagResult = trainer.Bag(enemyCurrentHP, enemyHP);
                    if (bagResult == 1){
                        enemyPokemon.CurrentHealth = enemyCurrentHP;
                        trainer.PokeTeam = trainer.CaughtPokemon(enemyPokemon);
                        trainer.BattleEndHealth(pokeCurrentHealth);
                        battleEnded = true;
                    }
                    else if (bagResult == 0){}
                    else {

                        pokeCurrentHealth = bagResult;
                    }
                break;

                case "run":
                Console.Write("\nYou got away safely.");
                Thread.Sleep(700);
                Console.Write(".");
                Thread.Sleep(700);
                Console.Write(".");
                Thread.Sleep(700);
                Console.Clear();
                trainer.BattleEndHealth(pokeCurrentHealth);
                battleEnded = true;
                break;
            }
            if (enemyCurrentHP <= 0) {
                Console.Clear();
                Console.WriteLine($"You defeated {enemyPokemon.GetPokeName()}!");
                Thread.Sleep(1500);
                trainer.BattleEndHealth(pokeCurrentHealth);
                battleEnded = true;
            }
            else if (pokeCurrentHealth <= 0) {
                Console.Clear();
                Console.WriteLine($"{trainerPokemon.GetPokeName()} fainted!");
                Console.WriteLine("You blacked out.");
                trainer.PokeTeam = trainer.Healing();
                Thread.Sleep(700);
                battleEnded = true;
            }
            else if (battleEnded == true) {

            }
            else {
            // Enemy Pokemon's return attack.
            currentMove = enemyPokemon.RandomMove();
                Console.WriteLine($"{enemyPokemon.GetPokeName()} used {currentMove.GetName()}!");
                Thread.Sleep(500);
                pokeCurrentHealth = pokeCurrentHealth - currentMove.CalculateDamage(trainerPokemon, enemyPokemon);
                Thread.Sleep(500);
            }
        }
        return trainer;
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