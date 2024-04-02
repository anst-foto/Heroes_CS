namespace Heroes;

public enum HeroSpecialization
{
    Mage, Warrior
}

public static class MapHeroSpecialization
{
    private static readonly Dictionary<HeroSpecialization, string> MapHeroSpecializations =
        new ()
        {
            { HeroSpecialization.Mage, nameof(HeroSpecialization.Mage) },
            { HeroSpecialization.Warrior, nameof(HeroSpecialization.Warrior) },
        };
    public static string GetHeroSpecialization(HeroSpecialization specialization)
    {
        return MapHeroSpecializations[specialization];
    }
}