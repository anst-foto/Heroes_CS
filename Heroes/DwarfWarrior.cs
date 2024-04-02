namespace Heroes;

public class DwarfWarrior : Dwarf, IWarrior
{
    public int Power { get; } = 27;
    
    public override void Attack(Hero enemy)
    {
        var totalDamage = Damage + Power;
        enemy.Health -= totalDamage;
    }
}