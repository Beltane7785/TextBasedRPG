using System.Security.Claims;
using System.Xml.Linq;

string[] monsterNames = ["Slime", "Goblin", "Orc", "Troll", "Dragon"];
string[] creatureTypes = ["Abberation", "Beast", "Humanoid"];
int[] possibleBaseRolls = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

Console.WriteLine("Welcome to the game. Would you like to start a new game? \n" 
    + "Options:\n"
    + "1: New Game\n"
    + "2: Continue");

string newGameOrContinue = Console.ReadLine();
bool newGame = false;

switch (newGameOrContinue)
{
    case "1": newGame = true; break;
    case "2": newGame = false; break;
}
if (newGame)
{
    Player player = InitializePlayer();

    Console.WriteLine($"Your name is {player.Name()}. You are a {player.GetClass()}. Your strength is {player.GetStats()[0]}. Your intelligence is {player.GetStats()[1]}. You dexterity is {player.GetStats()[2]}. Your HP is {player.GetHealthPoints()}. Your AC is {player.GetArmorClass()}. Your attack bonus is {player.GetAttackBonus()}. Are you pleased with this result?");
}
Player InitializePlayer()
{
    int allotedStatPoints = 20;

    Console.WriteLine("Greetings hero, what is your name?");
    string playerName = Console.ReadLine();

    Console.WriteLine($"Thank you, {playerName}. What class do you want to play?");
    string playerClass = Console.ReadLine();

    Console.WriteLine("Please allocate your stats.");
    Console.Write("Strength: ");
    int playerStrength = Convert.ToInt32(Console.ReadLine());
    Console.Write("Intelligence: ");
    int playerIntelligence = Convert.ToInt32(Console.ReadLine());
    Console.Write("Dexterity: ");
    int playerDexterity = Convert.ToInt32(Console.ReadLine());

    float playerAttackBonus = 0;

    if (playerClass == "Warrior" || playerClass == "warrior")
    {
        playerAttackBonus = .02f * playerStrength;
    }

    if (playerClass == "Rogue" || playerClass == "rogue")
    {
        playerAttackBonus = .02f * playerDexterity;
    }

    int playerArmorClass = 10;
    int playerHealth = 10;

    Player player = new Player(playerName, playerClass, playerHealth, playerArmorClass, playerStrength, playerIntelligence, playerDexterity, playerAttackBonus);

    return player;

}


void Combat(int playerInput, Monster monster, Player player) 
{
    
    int roundCount = 1;
    bool isPlayersTurn;
    bool isMonstersTurn;
    

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

    public string Name()
    {
        return name;
    }
    public string GetClass()
    {
        return Class;
    }
    public string SetClass(string value)
    {
        return Class = value;
    }
    public int GetHealthPoints()
    {
        return healthPoints;
    }

    public int SetHealthPoints(int value)
    {
        return healthPoints = value;
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