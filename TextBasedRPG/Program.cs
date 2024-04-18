using System.Security.Claims;
using System.Xml.Linq;

string[] monsterNames = ["Slime", "Goblin", "Orc", "Troll", "Dragon"];
string[] creatureTypes = ["Abberation", "Beast", "Humanoid"];

Monster Slime = new Monster("Slime", "Abberation", 10, 10, 10, 10, 10, .2f);
Player PlayerOne = new Player("Karrigan", "Warrior", 10, 10, 10, 10, 10, 2f);

Console.WriteLine(PlayerOne.GetName());

void Combat(int playerInput, Monster monster, Player player) 
{
    int roundCount = 1;
    switch (playerInput)
    {
        case 1: break;
    }

}
class Player
{
    private string name = "Placeholder";
    private string Class = "Warrior";

    private int healthPoints = 10;
    private int armorClass = 10;
    private int strength = 10;
    private int intelligence = 10;
    private int dexterity = 10;

    private float attackBonus = 0.2f;

    public string GetName()
    {
        return name;
    }
    public string GetClass()
    {
        return Class;
    }

    public int GetHealthPoints()
    {
        return healthPoints;
    }

    public int GetArmorClass()
    {
        return armorClass;
    }

    public int[] GetStats()
    {
        int[] Stats = [strength, intelligence, dexterity];
        return Stats;
    }

    public float GetAttackBonus()
    {
        return attackBonus; 
    }

    public Player(string _Name, string _Class, int _HealthPoints, int _ArmorClass, int _Strength, int _Intelligence, int _Dexterity, float _AttackBonus)
    {
        name = _Name;
        Class = _Class;
        healthPoints = _HealthPoints;
        armorClass = _ArmorClass;
        strength = _Strength;
        intelligence = _Intelligence;
        dexterity = _Dexterity;
        attackBonus = _AttackBonus;
    }
}

class Monster
{
    private string MonsterName = "Placeholder";
    private string MonsterType = "Placeholder";

    private int MonsterHealth = 10;
    private int MonsterArmorClass = 10;

    private int MonsterStrength = 10;
    private int MonsterIntelligence = 10;
    private int MonsterDexterity = 10;

    private float MonsterAttackBonus = 0.2f;
    public string GetMonsterName()
    {
        return MonsterName;
    }
    public string GetMonsterType()
    {
        return MonsterType;
    }

    public int GetMonsterHealth()
    {
        return MonsterHealth;
    }

    public int GetMonsterArmorClass()
    {
        return MonsterArmorClass;
    }

    public int[] GetMonsterStats()
    {
        int[] Stats = [MonsterStrength, MonsterIntelligence, MonsterDexterity];
        return Stats;
    }

    public float GetMonsterAttackBonus()
    {
        return MonsterAttackBonus;
    }
    public Monster(string _MonsterName, string _MonsterType, int _MonsterHealth, int _MonsterArmorClass, int _MonsterStrength, int _MonsterIntelligence, int _MonsterDexterity, float _MonsterAttackBonus)
    {
        MonsterName = _MonsterName;
        MonsterType = _MonsterType;

        MonsterHealth = _MonsterHealth;
        MonsterArmorClass = _MonsterArmorClass;

        MonsterStrength = _MonsterStrength;
        MonsterIntelligence = _MonsterIntelligence;
        MonsterDexterity= _MonsterDexterity;

        MonsterAttackBonus = _MonsterAttackBonus;
    }
}