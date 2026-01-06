class Elemental
{
    // state 
    public string Nickname;
    public int HP;
    public int AP;
    public string Type;
    public string Weakness;

    public Elemental(string name, int hp, int ap, string type)
    {
        this.Nickname = name;
        this.HP = hp;
        this.AP = ap;
        this.Type = type;

        InitWeakness(); // Decide what it's weakness is
    }

    private void InitWeakness()
    {
        if(this.Type == "Fire")
        {
            this.Weakness = "Water";
        }else if(this.Type == "Water")
        {
            this.Weakness = "Grass";
        }else if(this.Type == "Grass")
        {
            this.Weakness = "Fire";
        }
    }

    public void TakeAttack(Elemental attacker)
    {
        if(this.HP > 0)
        {
            if (this.IsWeakTo(attacker.Type)) // check if weak to
            {
                this.HP = this.HP - (attacker.AP * 2);
                Console.WriteLine($"{this.Nickname} is hit by {attacker.Nickname} for {attacker.AP * 2} damage");
                Console.WriteLine($"Critical hit because {this.Type} is weak to {attacker.Type}");
            }
            else
            {
                Console.WriteLine($"{this.Nickname} is hit by {attacker.Nickname} for {attacker.AP} damage");
                this.HP = this.HP - attacker.AP;
            }
        }
        
        if(this.HP > 0)
        {
            Console.WriteLine($"{this.Nickname} now has {this.HP} hp left");
        }
        else
        {
            Console.Write($"{this.Nickname} has fainted.");
        }
    }
    public bool IsWeakTo(string type)
    {
        if(this.Weakness == type)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}