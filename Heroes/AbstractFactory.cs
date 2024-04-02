namespace Heroes;

public abstract class AbstractFactory
{
    public abstract Elf CreateElf(string name);
    public abstract Dwarf CreateDwarf(string name);
}