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
}

// enum MoveType {
//     case tackle,
// }