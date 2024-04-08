using System;

class Type {
    private string typeName;
    private string weakness;
    private string resistance;

    public Type(string typeName, string weakness, string resistance) {
        this.typeName = typeName;
        this.weakness = weakness;
        this.resistance = resistance;
    }
    public string GetName() {
        return typeName;
    }
    public string GetWeakness() {
        return weakness;
    }
    public string GetResistance() {
        return resistance;
    }

    
}