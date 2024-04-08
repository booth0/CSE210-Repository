using System;

class Move {
    private string moveName;
    private int damageValue;
    Type moveType;
    public Move(string moveName, int damageValue, Type moveType){
        this.moveName = moveName;
        this.damageValue = damageValue;
        this.moveType = moveType;
    }

    public string GetName() {
        return moveName;
    }

    public int CalculateDamage(Pokemon defendingPokemon, Pokemon attackingPokemon) {
        
        double doubleNumber = ((2*attackingPokemon.GetLevel() / 5) + 2) * damageValue * (attackingPokemon.GetAttack()/ defendingPokemon.GetDefense())/50 * (defendingPokemon.WeakOrResists(moveType)/2);
        return (int) doubleNumber;
        
    }
}

// enum MoveType {
//     case tackle,
// }