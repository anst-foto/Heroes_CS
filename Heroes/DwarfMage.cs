namespace Heroes;

public class DwarfMage : Dwarf, IMage
{
    public int Mana { get; } = 27;
    
    public override void Attack(Hero enemy)
    {
        var totalDamage = Damage + Mana;
        enemy.Health -= totalDamage;
    }
}