using System.Collections.Generic;

public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }

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
}
