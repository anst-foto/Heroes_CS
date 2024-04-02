namespace Heroes;

public enum HeroType
{
    Elf, Dwarf
}

public static class MapHeroType
{
    private static readonly Dictionary<HeroType, string> MapHeroTypes = new()
    {
        { HeroType.Elf, nameof(HeroType.Elf) },
        { HeroType.Dwarf, nameof(HeroType.Dwarf) }
    };
    
    public static string GetHeroType(HeroType heroType) => MapHeroTypes[heroType];
}