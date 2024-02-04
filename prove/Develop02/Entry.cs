using System;
public class Entry {
    public string prompt;
    public string response;
    public string date;

    public Entry(string prompt, string response, string date){
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    

    public Entry(string import) {
        var parts = import.Split("|");
        this.prompt = parts[0];
        this.response = parts[1];
        this.date = parts[2];
    }
 
    
    public string Export()
    {
        return $"{prompt}|{response}|{date}";
    }

    public string Display(){
        return $"{date}\nPrompt: {prompt}\nResponse: {response}\n";
    }
}