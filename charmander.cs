class charmander
{
    public String name;
    public String type;
    public String weakness;
    public int hp;

    public charmander(string name, string type, string weakness, int hp)
    {
        this.name = name;
        this.type = type;
        this.weakness = weakness;
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