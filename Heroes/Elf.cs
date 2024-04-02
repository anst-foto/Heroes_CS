namespace Heroes;

public abstract class Elf : Hero
{
    private const int HEALTH = 100;
    private const int DAMAGE = 10;

    protected Elf()
    {
        Health = HEALTH;
        Damage = DAMAGE;
    }
}