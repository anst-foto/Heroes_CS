namespace Heroes;

public class WarriorFactory : AbstractFactory
{
    public override Elf CreateElf(string name)
    {
        return new ElfWarrior() { Name = name };
    }

    public override Dwarf CreateDwarf(string name)
    {
        return new DwarfWarrior() { Name = name };
    }
}