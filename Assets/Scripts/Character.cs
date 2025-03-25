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

    public void Equip(Item item)
    {
        item.Equip();
    }

    public void UnEquip(Item item)
    {
        item.UnEquip();
    }

    // 장착된 아이템 기반으로 스탯 계산
    public int GetTotalStat(StatType type)
    {
        int bonus = Inventory.Where(i => i.IsEquipped && i.StatType == type).Sum(i => i.StatAmount);
        return type switch
        {
            StatType.Attack => BaseAttack + bonus,
            StatType.Defense => BaseDefense + bonus,
            StatType.HP => BaseHP + bonus,
            StatType.Crit => BaseCrit + bonus,
            _ => bonus
        };
    }
}
