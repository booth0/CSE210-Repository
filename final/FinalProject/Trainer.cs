using System;

class Trainer {
    private string trainerName;
    private List<Pokemon> pokeTeam;
    private List<Item> bag;
    public Trainer(string trainerName, List<Pokemon> pokeTeam, List<Item> bag){
        this.trainerName = trainerName;
        this.pokeTeam = pokeTeam;
        this.bag = bag;
    }

    public Pokemon GetPokemon() {
        return pokeTeam[0];
    }
}