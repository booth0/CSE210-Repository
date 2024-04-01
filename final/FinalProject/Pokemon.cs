using System;

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
        this.pokeType = pokeType;
        this.pokeLevel = pokeLevel;
        this.health = health;
        this.currentHealth = currentHealth;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
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
}