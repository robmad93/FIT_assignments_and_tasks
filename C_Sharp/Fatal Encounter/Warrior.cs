class Warrior
{
    public string Name;
    public string Type;
    public int Attack;
    public int Health;

    public int Defense;
    public int Speed;
    public string Weakness;
    

public Warrior()
{
    InitWeakness();
}
public void InitWeakness()
    {
        if(this.Type == "Brute")
        {
            this.Weakness = "Ranged";
        }else if(this.Type == "Agile")
        {
            this.Weakness = "Brute";
        }else if(this.Type == "Ranged")
        {
            this.Weakness = "Agile";
        }
    }

    public void TakeAttack(Warrior attacker)
    {
        if(this.Health > 0)
        {
            if (this.IsWeakTo(attacker.Type)) // check if weak to
            {
                this.Health = this.Health - (attacker.Attack * 2);
                Console.WriteLine($"{this.Name} is hit by {attacker.Name} for {attacker.Attack * 2} damage");
                Console.WriteLine($"Critical hit because {this.Type} is weak to {attacker.Type}");
            }
            else
            {
                Console.WriteLine($"{this.Name} is hit by {attacker.Name} for {attacker.Attack} damage");
                this.Health = this.Health - attacker.Attack;
            }
        }
        
        if(this.Health > 0)
        {
            Console.WriteLine($"{this.Name} now has {this.Health} hp left");
        }
        else
        {
            Console.Write($"{this.Name} has fainted.");
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

