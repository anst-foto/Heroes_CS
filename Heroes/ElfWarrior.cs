namespace Heroes;

public class ElfWarrior : Elf, IWarrior
{
    public int Power { get; } = 20;
    
    public override void Attack(Hero enemy)
    {
        var totalDamage = Damage + Power;
        enemy.Health -= totalDamage;
    }
}