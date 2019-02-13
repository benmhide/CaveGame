# CaveGame
Procedurally generate cave adventure game created for the UROS project at University of Lincoln.

# Game features:
-	Procedurally generated map / caves <br />
Rock cubes – less juicy / fewer hits to destroy <br />
Crystal cubes – More juicy more hits to destroy <br />
<br />
  
-	Quest system feat. Four quests <br />
1) Collect pickups (gold)<br />
2) Search for keys to open chests to collect artefacts<br />
3) Kill monsters<br />
4) Exit the caves (complete game)<br />
Hidden quest) Save/kill civilian (male/female/cat)<br />
<br />  
  
- Selectable font sizes for in game text<br />
<br />

- Selectable colour settings for game<br />
1) Normal mode<br />
2) Red colour blind mode<br />
3) Green colour blind mode<br />
4) Blue colour blind mode<br />
  <br />
  
-	Selectable character<br />
Male<br />
Female<br />
<br />

-	Two monster types<br />
1) Basic monster (less juicy damaged effects and shrinks on death / no death particles)<br />
2) Juicy monsters (increased juiciness when damaging / killing monster)<br />
  <br />
  
-	Game and settings data collection via firebase. Collected data detailed below in firebase data section.<br />
<br />

-	Playable character has two actions<br />
1) Digging through rock / crystal cubes – attacking monsters using pickaxe<br />
2) Dropping TNT to destroy rock / crystal cubes – killing monsters<br />

<br />
# Firebase Data Collected
/ Global game data manager enums
public enum GENDER { MALE, FEMALE }
public enum COLOURSCHEME { CVD, NORMAL }
public enum CVDCOLOURSCHEME { RED, GREEN, BLUE, NONE }
public enum FONTSIZE { SMALL, MEDIUM, LARGE }
public enum CIVILLIANTYPE { MALE, FEMALE, CAT }

// Game stat classes
public class ChestStat
{
    public float spawnTime;
    public float openedTime;
    public bool opened;
    public Vector3 position;
}

public class KeyStat
{
    public float spawnTime;
    public float collectedTime;
    public bool collected;
    public Vector3 position;
}

public class PickupStat
{
    public float spawnTime;
    public float collectedTime;
    public bool collected;
    public Vector3 position;
}

public class QuestStat
{
    public float startTime;
    public float endTime;
    public string name;
    public bool complete;
}

public class MonsterStat
{
    public float spawnTime;
    public float killedTime;
    public Vector3 killedPos;
    public Vector3 spawnedPos;
    public MONSTERTYPE type;
    public bool killed;
    public bool killedInQuest;
}

public class CubeStat
{
    public Vector3 position;
    public CUBETYPE type;
}

public class CubeDestroyedStat
{
    public Vector3 position;
    public CUBETYPE type;
    public bool destroyed;
    public float destroyedTime;
}

public class CivillianStat
{
    public Vector3 position;
    public CIVILLIANTYPE type;
    public bool saved;
    public bool killed;
    public float savedKilledTime;
}

public class TNTStat
{
    public Vector3 position;
    public float usedTime;
}

public class HealthStat
{
    public float collectedTime;
    public float spawnTime;
    public bool collected;
    public Vector3 position;
}

public class GameDataManager 
- Player settings / statistics
playerName;
playerHealth;
playerScore;
genderInitial;
genderSelected;
List<Vector3> playerPositionsList;
List<TNTStat> playerTNTStatsList;
List<HealthStat> playerHealthPickupStatsList;

- Accessability settings
selectedFontSize;
selectedColourScheme;
selectedCVDColourScheme;

- Grid cube counts
numberOfTotalCubes;
numberOfRockCubes;
numberOfCrystalCubes;
numberOfCubesDestroyed;
numberOfCubesDestroyedRock;
numberOfCubesDestroyedCrystal;

- Pickup statistics
pickupsTotal;
pickupsCollected;

- Chests statistics
chestsTotal;
chestsOpened;
keysTotal;
keysCollected;

- Monster statistics
monstersTotal;
monstersBasic;
monstersJuicy;
monstersKilledTotal;
monstersKilledBasic;
monstersKilledJuicy;

- Game statistics
string[] questNames;
questsNumber;
List<QuestStat> questStatsList;
questOldMinerPosition;

- Civillian statistics
civillianType;
civillianStats;
civillianPosition;

- Cube positional statistics
List<CubeDestroyedStat> cubePositionsDestroyed;
List<CubeStat> cubePositionsStart;
List<CubeStat> cubePositionsEnd;

 - Monster positional statistics
List<MonsterStat> monsterKilledStatsBasicList;
List<MonsterStat> monsterKilledStatsJuicyList;

- Objective positional statistics
List<PickupStat> listPickupStats;
List<ChestStat> listChestStats;
List<KeyStat> listKeyStats;
<br />

# Colour settings
To modify colour settings the values sorted in the Colours C# file need to be modified.<br />

The Colours C# file is located in:<br />
CaveGame-master\UROS 1.12\Assets\\_Utilities\Scripts folder (called "Colours.cs")<br />

Colours used in the game can be set for all colour blind settings and normal colour settings. Colours defined in this file will automatically be used during the game. The Unity colours used in this file are clearly named and should be easy to modify with any RGBA values.<br />

Colours are as follows:
