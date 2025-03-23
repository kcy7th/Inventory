using UnityEngine;

public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }
    public int HP { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Crit { get; private set; }

    public Character(string name, int level, int gold, int hp, int atk, int def, int crit)
    {
        Name = name;
        Level = level;
        Gold = gold;
        HP = hp;
        Attack = atk;
        Defense = def;
        Crit = crit;
    }
}
