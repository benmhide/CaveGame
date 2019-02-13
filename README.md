# CaveGame
Procedurally generate cave adventure game created for the UROS project at University of Lincoln.

# Game features:
-	Procedurally generated map / caves <br />
1) Rock cubes – less juicy / fewer hits to destroy <br />
2) Crystal cubes – More juicy more hits to destroy <br />
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
- Global game data manager enums<br />
enum GENDER { MALE = 0, FEMALE = 1 }<br />
public enum COLOURSCHEME { CVD = 0, NORMAL = 1 }<br />
public enum CVDCOLOURSCHEME { RED = 0, GREEN = 1, BLUE = 2, NONE = 3 }<br />
public enum FONTSIZE { SMALL = 0, MEDIUM = 1, LARGE = 2 }<br />
public enum CIVILLIANTYPE { MALE = 0, FEMALE = 1, CAT = 2 }<br />

- Game stat classes<br /><br />
public class ChestStat<br />
{<br />
    public float spawnTime;<br />
    public float openedTime;<br />
    public bool opened;<br />
    public Vector3 position;<br />
}<br /><br />

public class KeyStat<br />
{<br />
    public float spawnTime;<br />
    public float collectedTime;<br />
    public bool collected;<br />
    public Vector3 position;<br />
}<br /><br />

public class PickupStat<br />
{<br />
    public float spawnTime;<br />
    public float collectedTime;<br />
    public bool collected;<br />
    public Vector3 position;<br />
}<br /><br />

public class QuestStat<br />
{<br />
    public float startTime;<br />
    public float endTime;<br />
    public string name;<br />
    public bool complete;<br />
}<br /><br />

public class MonsterStat<br />
{<br />
    public float spawnTime;<br />
    public float killedTime;<br />
    public Vector3 killedPos;<br />
    public Vector3 spawnedPos;<br />
    public MONSTERTYPE type;<br />
    public bool killed;<br />
    public bool killedInQuest;<br />
}<br /><br />

public class CubeStat<br />
{<br />
    public Vector3 position;<br />
    public CUBETYPE type;<br />
}<br /><br />

public class CubeDestroyedStat<br />
{<br />
    public Vector3 position;<br />
    public CUBETYPE type;<br />
    public bool destroyed;<br />
    public float destroyedTime;<br />
}<br />

public class CivillianStat<br />
{<br />
    public Vector3 position;<br />
    public CIVILLIANTYPE type;<br />
    public bool saved;<br />
    public bool killed;<br />
    public float savedKilledTime;<br />
}<br /><br />

public class TNTStat<br />
{<br />
    public Vector3 position;<br />
    public float usedTime;<br />
}<br /><br />

public class HealthStat<br />
{<br />
    public float collectedTime;<br />
    public float spawnTime;<br />
    public bool collected;<br />
    public Vector3 position;<br />
}<br /><br />

public class GameDataManager 
- Player settings / statistics<br />
playerName;<br />
playerHealth;<br />
playerScore;<br />
genderInitial;<br />
genderSelected;<br />
List<Vector3> playerPositionsList;<br />
List<TNTStat> playerTNTStatsList;<br />
List<HealthStat> playerHealthPickupStatsList;<br />
<br />
- Accessability settings<br />
selectedFontSize;<br />
selectedColourScheme;<br />
selectedCVDColourScheme;<br />
<br />
- Grid cube counts<br />
numberOfTotalCubes;<br />
numberOfRockCubes;<br />
numberOfCrystalCubes;<br />
numberOfCubesDestroyed;<br />
numberOfCubesDestroyedRock;<br />
numberOfCubesDestroyedCrystal;<br />
<br />
- Pickup statistics<br />
pickupsTotal;<br />
pickupsCollected;<br />
<br />
- Chests statistics<br />
chestsTotal;<br />
chestsOpened;<br />
keysTotal;<br />
keysCollected;<br />
<br />
- Monster statistics<br />
monstersTotal;<br />
monstersBasic;<br />
monstersJuicy;<br />
monstersKilledTotal;<br />
monstersKilledBasic;<br />
monstersKilledJuicy;<br />
<br />
- Game statistics<br />
string[] questNames;<br />
questsNumber;<br />
List<QuestStat> questStatsList;<br />
questOldMinerPosition;<br />
<br />
- Civillian statistics<br />
civillianType;<br />
civillianStats;<br />
civillianPosition;<br />
<br />
- Cube positional statistics<br />
List<CubeDestroyedStat> cubePositionsDestroyed;<br />
List<CubeStat> cubePositionsStart;<br />
List<CubeStat> cubePositionsEnd;<br />
<br />
 - Monster positional statistics<br />
List<MonsterStat> monsterKilledStatsBasicList;<br />
List<MonsterStat> monsterKilledStatsJuicyList;<br />
<br />
- Objective positional statistics<br />
List<PickupStat> listPickupStats;<br />
List<ChestStat> listChestStats;<br />
List<KeyStat> listKeyStats;<br />
<br />

# Colour settings
To modify colour settings the values sorted in the Colours C# file need to be modified.<br />

The Colours C# file is located in:<br />
CaveGame-master\UROS 1.12\Assets\\_Utilities\Scripts folder (called "Colours.cs")<br />

Colours used in the game can be set for all colour blind settings and normal colour settings. Colours defined in this file will automatically be used during the game. The Unity colours used in this file are clearly named and should be easy to modify with any RGBA values.<br />

Colours are as follows:
