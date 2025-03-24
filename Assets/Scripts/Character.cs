using System.Collections.Generic;
using System.Linq;

public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }

    public int BaseAttack = 10;
    public int BaseDefense = 5;
    public int BaseHP = 100;
    public int BaseCrit = 0;

    public List<Item> Inventory { get; private set; }

    public Character(string name, int level, int gold)
    {
        Name = name;
        Level = level;
        Gold = gold;
        Inventory = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public int GetTotalAttack()
    {
        int bonus = Inventory.Where(i => i.IsEquipped && i.StatType == StatType.Attack).Sum(i => i.StatAmount);
        return BaseAttack + bonus;
    }
    public int GetTotalDefense()
    {
        int bonus = Inventory.Where(i => i.IsEquipped && i.StatType == StatType.Defense).Sum(i => i.StatAmount);
        return BaseDefense + bonus;
    }
    public int GetTotalHP()
    {
        int bonus = Inventory.Where(i => i.IsEquipped && i.StatType == StatType.HP).Sum(i => i.StatAmount);
        return BaseHP + bonus;
    }
    public int GetTotalCrit()
    {
        int bonus = Inventory.Where(i => i.IsEquipped && i.StatType == StatType.Crit).Sum(i => i.StatAmount);
        return BaseCrit + bonus;
    }
}
