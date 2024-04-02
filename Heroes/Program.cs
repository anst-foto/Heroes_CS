using Heroes;

Cli.PrintInfo("Введите имя");
var name = Console.ReadLine();

AbstractFactory factoryHero = Game.GetHeroSpecialization() switch
{
    HeroSpecialization.Mage => new MageFactory(),
    HeroSpecialization.Warrior => new WarriorFactory()
};

Hero hero = Game.GetHeroType() switch
{
    HeroType.Elf => factoryHero.CreateElf(name),
    HeroType.Dwarf => factoryHero.CreateDwarf(name)
};

Hero enemy = new ElfMage() { Name = "Enemy"}; //FIXME

do
{
    Game.PrintHeroInfo(hero);
    Thread.Sleep(500);
    Game.PrintHeroInfo(enemy);
    Thread.Sleep(500);
    
    hero.Attack(enemy);
    if (enemy.IsDead) break;
    enemy.Attack(hero);
    if (hero.IsDead) break;
    Thread.Sleep(1000);
} while (true);

if (hero.IsDead)
{
    Cli.PrintError($"{hero.Name} is dead");
    return;
}

if (enemy.IsDead)
{
    Cli.PrintError($"{enemy.Name} is dead");
    return;
}