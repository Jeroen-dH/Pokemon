using System;

class Program
{
    public static void Main(string[] args)
    {
        pokemon charmander = new pokemon("beef", "fire", 100);
        Console.WriteLine(charmander.getName());
        Console.WriteLine(charmander.getType());
    }
}

class pokemon
{
    public String name;
    public String type;
    public int hp;

    public pokemon(string name, string type, int hp)
    {
        this.name = name;
        this.type = type;
        this.hp = hp;
    }
    public string getName()
    {
        return name;
    }
    public string getType()
    {
        return type;
    }

    public void setName(string name)
    {
        this.name = name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
}