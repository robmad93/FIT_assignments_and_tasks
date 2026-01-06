class Program
{

    public static void Main(string[] args)
    {
       Elemental[] fighters = new Elemental[2];
        fighters[0] = new Elemental("charredmander", 15, 12, "Fire");
        fighters[1] = new Elemental("squortle", 15, 12, "Water");
        while (fighters[0].HP > 0 && fighters[1].HP > 0)
        {
            InitiateAttack(fighters);
        }
    }
    public static void InitiateAttack(Elemental[] fighters)
    {
        
        int attacker = new Random().Next(2); // 0 or 1
        if(attacker == 0)
        {
            SimulateAttack(fighters[0], fighters[1]);
        }
        else
        {
            SimulateAttack(fighters[1], fighters[0]);
        }
    }
    public static void SimulateAttack(Elemental attacker, Elemental defender)
    {
        defender.TakeAttack(attacker);
    } 

}