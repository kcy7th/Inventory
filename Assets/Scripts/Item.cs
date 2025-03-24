using UnityEngine;

public enum StatType { Attack, Defense, HP, Crit }

public class Item
{
    public string Name { get; private set; }
    public Sprite Icon { get; private set; }
    public bool IsEquipped { get; private set; }

    public StatType StatType { get; private set; }
    public int StatAmount { get; private set; }

    public Item(string name, Sprite icon, StatType statType, int statAmount)
    {
        Name = name;
        Icon = icon;
        StatType = statType;
        StatAmount = statAmount;
        IsEquipped = false;
    }

    public void Equip() => IsEquipped = true;
    public void UnEquip() => IsEquipped = false;
}
