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

# Firebase Data Collected:

# Global game data manager enums:
1) enum GENDER { MALE = 0, FEMALE = 1 }
2) enum CVDCOLOURSCHEME { RED = 0, GREEN = 1, BLUE = 2, NONE = 3 }
3) enum FONTSIZE { SMALL = 0, MEDIUM = 1, LARGE = 2 }
4) enum CIVILLIANTYPE { MALE = 0, FEMALE = 1, CAT = 2 }
5) enum MONSTERTYPE { BASIC, JUICY }


# Game stat classes

- class ChestStat<br />
{<br />
    float spawnTime;<br />
    float openedTime;<br />
    bool opened;<br />
    Vector3 position;<br />
}<br /><br />

- class KeyStat<br />
{<br />
    float spawnTime;<br />
    float collectedTime;<br />
    bool collected;<br />
    Vector3 position;<br />
}<br /><br />

- class PickupStat<br />
{<br />
    float spawnTime;<br />
    float collectedTime;<br />
    bool collected;<br />
    Vector3 position;<br />
}<br /><br />

- class QuestStat<br />
{<br />
    float startTime;<br />
    float endTime;<br />
    string name;<br />
    bool complete;<br />
}<br /><br />

- class MonsterStat<br />
{<br />
    float spawnTime;<br />
    float killedTime;<br />
    Vector3 killedPos;<br />
    Vector3 spawnedPos;<br />
    MONSTERTYPE type;<br />
    bool killed;<br />
    bool killedInQuest;<br />
}<br /><br />

- class CubeStat<br />
{<br />
    Vector3 position;<br />
    CUBETYPE type;<br />
}<br /><br />

- class CubeDestroyedStat<br />
{<br />
    Vector3 position;<br />
    CUBETYPE type;<br />
    bool destroyed;<br />
    float destroyedTime;<br />
}<br />

- class CivillianStat<br />
{<br />
    Vector3 position;<br />
    CIVILLIANTYPE type;<br />
    bool saved;<br />
    bool killed;<br />
     float savedKilledTime;<br />
}<br /><br />

- class TNTStat<br />
{<br />
    Vector3 position;<br />
    float usedTime;<br />
}<br /><br />

- class HealthStat<br />
{<br />
    float collectedTime;<br />
    float spawnTime;<br />
    bool collected;<br />
    Vector3 position;<br />
}<br /><br />

# Game statistics collected

- Player settings / statistics
playerName;<br />
playerHealth;<br />
playerScore;<br />
genderInitial;<br />
genderSelected;<br />
List<Vector3> playerPositionsList;<br />
List<TNTStat> playerTNTStatsList;<br />
List<HealthStat> playerHealthPickupStatsList;<br />

- Accessability settings
selectedFontSize;<br />
selectedColourScheme;<br />
selectedCVDColourScheme;<br />

- Grid cube counts
numberOfTotalCubes;<br />
numberOfRockCubes;<br />
numberOfCrystalCubes;<br />
numberOfCubesDestroyed;<br />
numberOfCubesDestroyedRock;<br />
numberOfCubesDestroyedCrystal;<br />

- Pickup statistics
pickupsTotal;<br />
pickupsCollected;<br />

- Chests statistics
chestsTotal;<br />
chestsOpened;<br />
keysTotal;<br />
keysCollected;<br />

- Monster statistics
monstersTotal;<br />
monstersBasic;<br />
monstersJuicy;<br />
monstersKilledTotal;<br />
monstersKilledBasic;<br />
monstersKilledJuicy;<br />

- Game statistics
string[] questNames;<br />
questsNumber;<br />
List<QuestStat> questStatsList;<br />
questOldMinerPosition;<br />

- Civillian statistics
civillianType;<br />
civillianStats;<br />
civillianPosition;<br />

- Cube positional statistics
List<CubeDestroyedStat> cubePositionsDestroyed;<br />
List<CubeStat> cubePositionsStart;<br />
List<CubeStat> cubePositionsEnd;<br />

 - Monster positional statistics
List<MonsterStat> monsterKilledStatsBasicList;<br />
List<MonsterStat> monsterKilledStatsJuicyList;<br />

- Objective positional statistics
List<PickupStat> listPickupStats;<br />
List<ChestStat> listChestStats;<br />
List<KeyStat> listKeyStats;<br />


# Colour settings
To modify colour settings the values sorted in the Colours C# file need to be modified.<br />

The Colours C# file is located in:<br />
CaveGame-master\UROS 1.12\Assets\\_Utilities\Scripts folder (called "Colours.cs")<br />

Colours used in the game can be set for all colour blind settings and normal colour settings. Colours defined in this file will automatically be used during the game. The Unity colours used in this file are clearly named and should be easy to modify with any RGBA values.<br />

Colours are as follows:
