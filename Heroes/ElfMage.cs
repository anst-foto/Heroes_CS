namespace Heroes;

public class ElfMage : Elf, IMage
{
    public int Mana { get; } = 25;
    
    public override void Attack(Hero enemy)
    {
        var totalDamage = Damage + Mana;
        enemy.Health -= totalDamage;
    }
}