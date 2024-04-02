namespace Heroes;

public static class Game
{
    public static void PrintHeroInfo(Hero hero)
    {
        Cli.PrintInfo($"=== {hero.Name} ===");
        Cli.PrintInfo($"=== HEALTH: {hero.Health} ===");
        Cli.PrintInfo($"=== DAMAGE: {hero.Damage} ===");
        Cli.PrintInfo($"=== === ===");
    }

    private static string InputHeroSpecialization()
    {
        Cli.PrintWarning("********************************");
        Cli.PrintWarning("* Выберите специализацию героя: *");
        Cli.PrintWarning($"* 1. {MapHeroSpecialization.GetHeroSpecialization(HeroSpecialization.Mage)} *");
        Cli.PrintWarning($"* 2. {MapHeroSpecialization.GetHeroSpecialization(HeroSpecialization.Warrior)} *");
        var heroSpecializationInput = Console.ReadLine();
        Cli.PrintWarning("********************************");
    
        return heroSpecializationInput;
    }

    private static string InputHeroType()
    {
        Cli.PrintWarning("++++++++++++++++");
        Cli.PrintWarning("+ Выберите тип героя: +");
        Cli.PrintWarning($"+ 1. {MapHeroType.GetHeroType(HeroType.Elf)} +");
        Cli.PrintWarning($"+ 2. {MapHeroType.GetHeroType(HeroType.Dwarf)} +");
        var heroTypeInput = Console.ReadLine();
        Cli.PrintWarning("++++++++++++++++");
    
        return heroTypeInput;
    }

    public static HeroSpecialization GetHeroSpecialization()
    {
        var heroSpecializationInput = InputHeroSpecialization();
        return heroSpecializationInput switch
        {
            "1" => HeroSpecialization.Mage,
            "2" => HeroSpecialization.Warrior,
            _ => throw new ArgumentOutOfRangeException(nameof(heroSpecializationInput), heroSpecializationInput, null)
        };
    }

    public static HeroType GetHeroType()
    {
        var heroTypeInput = InputHeroType();
        return heroTypeInput switch
        {
            "1" => HeroType.Elf,
            "2" => HeroType.Dwarf,
            _ => throw new ArgumentOutOfRangeException(nameof(heroTypeInput), heroTypeInput, null)
        };
    }
}