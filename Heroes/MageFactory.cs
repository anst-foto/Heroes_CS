namespace Heroes;

public class MageFactory : AbstractFactory
{
    public override Elf CreateElf(string name)
    {
        return new ElfMage() { Name = name };
    }

    public override Dwarf CreateDwarf(string name)
    {
        return new DwarfMage() { Name = name };
    }
}