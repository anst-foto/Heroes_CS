namespace Heroes;

public abstract class Dwarf : Hero
{
    private const int HEALTH = 110;
    private const int DAMAGE = 7;

    protected Dwarf()
    {
        Health = HEALTH;
        Damage = DAMAGE;
    }
}