namespace Heroes;

public abstract class Hero
{
    public required string Name { get; init; }

    private int _health;
    public int Health
    {
        get => _health;
        set => _health = value <= 0 ? 0 : value;
    }

    public int Damage { get; protected init; }

    public bool IsDead => _health == 0;
    
    public abstract void Attack(Hero enemy);
}