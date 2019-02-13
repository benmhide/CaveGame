# CaveGame
Procedurally generate cave adventure game created for the UROS project at University of Lincoln.

## Colours need to be set in the Colours.cs file inside the assets folder before the game will work with all colour settings. In its current state the coloir blind settings won't work and will crash the game. Once all the colours inside this Colours.cs file are completed the game needs to be rebuilt - NO OTHER SETTINGS SHOULD NEED CHANGING JUST A NEW BUILD OF THE GAME. See below for further details.


## Game features:
-	**Procedurally generated map / caves** <br />
1) Rock cubes – less juicy / fewer hits to destroy <br />
2) Crystal cubes – More juicy more hits to destroy <br />
<br />
  
-	**Quest system feat. Four quests** <br />
1) Collect pickups (gold)<br />
2) Search for keys to open chests to collect artefacts<br />
3) Kill monsters<br />
4) Exit the caves (complete game)<br />
5) Save/kill civilian either male/female/cat (hidden quest)<br />
<br />  
  
- **Selectable font sizes for in game text**<br />
<br />

- **Selectable colour settings for game**<br />
1) Normal mode<br />
2) Red colour blind mode<br />
3) Green colour blind mode<br />
4) Blue colour blind mode<br />
  <br />
  
-	**Selectable character**<br />
1) Male<br />
2) Female<br />
<br />

-	**Two monster types**<br />
1) Basic monster (less juicy damaged effects and shrinks on death / no death particles)<br />
2) Juicy monsters (increased juiciness when damaging / killing monster)<br />
  <br />
  
-	**Game and settings data collection via firebase. Collected data detailed below in firebase data section.**<br />
<br />

-	**Playable character has two actions**<br />
1) Digging through rock / crystal cubes – attacking monsters using pickaxe<br />
2) Dropping TNT to destroy rock / crystal cubes – killing monsters<br />

<br />

# Firebase Data Collected:

## Global game data manager enums:
1) **GENDER** { MALE = 0, FEMALE = 1 }
2) **CVDCOLOURSCHEME** { RED = 0, GREEN = 1, BLUE = 2, NONE = 3 }
3) **FONTSIZE** { SMALL = 0, MEDIUM = 1, LARGE = 2 }
4) **CIVILLIANTYPE** { MALE = 0, FEMALE = 1, CAT = 2 }
5) **MONSTERTYPE** { BASIC = 0, JUICY = 1 }


## Game stat classes

- **class ChestStat**
{<br />
    float spawnTime;<br />
    float openedTime;<br />
    bool opened;<br />
    Vector3 position;<br />
}<br />

- **class KeyStat**
{<br />
    float spawnTime;<br />
    float collectedTime;<br />
    bool collected;<br />
    Vector3 position;<br />
}<br />

- **class PickupStat**
{<br />
    float spawnTime;<br />
    float collectedTime;<br />
    bool collected;<br />
    Vector3 position;<br />
}<br /><br />

- **class QuestStat**
{<br />
    float startTime;<br />
    float endTime;<br />
    string name;<br />
    bool complete;<br />
}<br />

- **class MonsterStat**
{<br />
    float spawnTime;<br />
    float killedTime;<br />
    Vector3 killedPos;<br />
    Vector3 spawnedPos;<br />
    MONSTERTYPE type;<br />
    bool killed;<br />
    bool killedInQuest;<br />
}<br />

- **class CubeStat**
{<br />
    Vector3 position;<br />
    CUBETYPE type;<br />
}<br /><br />

- **class CubeDestroyedStat**
{<br />
    Vector3 position;<br />
    CUBETYPE type;<br />
    bool destroyed;<br />
    float destroyedTime;<br />
}<br />

- **class CivillianStat**
{<br />
    Vector3 position;<br />
    CIVILLIANTYPE type;<br />
    bool saved;<br />
    bool killed;<br />
     float savedKilledTime;<br />
}<br />

- **class TNTStat**
{<br />
    Vector3 position;<br />
    float usedTime;<br />
}<br />

- **class HealthStat**
{<br />
    float collectedTime;<br />
    float spawnTime;<br />
    bool collected;<br />
    Vector3 position;<br />
}<br />

## Game statistics collected

- **Player settings / statistics**
    - playerName;<br />
    - playerHealth;<br />
    - playerScore; (end of game)<br />
    - genderInitial;<br />
    - genderSelected;<br />
    - List<Vector3> playerPositionsList;<br />
    - List<TNTStat> playerTNTStatsList;<br />
    - List<HealthStat> playerHealthPickupStatsList;<br /><br />

- **Accessability settings**
    - selectedFontSize;<br />
    - selectedColourScheme;<br />
    - selectedCVDColourScheme;<br /><br />

- **Grid cube counts**
    - numberOfTotalCubes;<br />
    - numberOfRockCubes;<br />
    - numberOfCrystalCubes;<br />
    - numberOfCubesDestroyed;<br />
    - numberOfCubesDestroyedRock;<br />
    - numberOfCubesDestroyedCrystal;<br /><br />

- **Pickup statistics**
    - pickupsTotal;<br />
    - pickupsCollected;<br /><br />

- **Chests statistics**
    - chestsTotal;<br />
    - chestsOpened;<br />
    - keysTotal;<br />
    - keysCollected;<br /><br />

- **Monster statistics**
    - monstersTotal;<br />
    - monstersBasic;<br />
    - monstersJuicy;<br />
    - monstersKilledTotal;<br />
    - monstersKilledBasic;<br />
    - monstersKilledJuicy;<br /><br />

- **Game statistics**
    - string[] questNames;<br />
    - questsNumber;<br />
    - List<QuestStat> questStatsList;<br />
    - questOldMinerPosition;<br /><br />

- **Civillian statistics**
    - civillianType;<br />
    - civillianStats;<br />
    - civillianPosition;<br /><br />

- **Cube positional statistics**
    - List<CubeDestroyedStat> cubePositionsDestroyed;<br />
    - List<CubeStat> cubePositionsStart;<br />
    - List<CubeStat> cubePositionsEnd;<br /><br />

 - **Monster positional statistics**
    - List<MonsterStat> monsterKilledStatsBasicList;<br />
    - List<MonsterStat> monsterKilledStatsJuicyList;<br /><br />

- **Objective positional statistics**
    - List<PickupStat> listPickupStats;<br />
    - List<ChestStat> listChestStats;<br />
    - List<KeyStat> listKeyStats;<br /><br />


# Colour settings
To modify colour settings the values sorted in the Colours C# file need to be modified.<br />

The Colours C# file is located in:<br />
**CaveGame-master\UROS 1.12\Assets\\_Utilities\Scripts folder (called "Colours.cs")**
<br />

Colours used in the game can be set for all colour blind settings and normal colour settings. Colours defined in this file will automatically be used during the game. The Unity colours used in this file are clearly named and should be easy to modify with any RGBA values.<br />

## **Colours are as follows:**
- FLOOR COLOURS (**SET NORMAL COLOUR**)
  - floorColour = new Color(191.0f / 255.0f, 171.0f / 225.0f, 133.0f / 255.0f); 
  - floorColourRedSafe = new Color(191.0f / 255.0f, 171.0f / 225.0f, 133.0f / 255.0f);
  - floorColourGreenSafe = new Color(204.0f / 255.0f, 204.0f / 255.0f, 204.0f / 255.0f);
  - floorColourBlueSafe = new Color(204.0f / 255.0f, 204.0f / 255.0f, 204.0f / 255.0f); 


- EDGE COLOURS (**SET NORMAL COLOUR**)
  - edgeColour = new Color(48.0f / 255.0f, 48.0f / 255.0f, 48.0f / 255.0f); 
  - edgeColourRedSafe = new Color(48.0f / 255.0f, 48.0f / 255.0f, 48.0f / 255.0f);
  - edgeColourGreenSafe = new Color(45.0f / 255.0f, 31.0f / 255.0f, 0.0f / 255.0f);
  - edgeColourBlueSafe = new Color(45.0f / 255.0f, 31.0f / 255.0f, 0.0f / 255.0f); 


- BORDER COLOURS (**COPIED FROM ABOVE**)
  - borderColour = new Color(edgeColour.r, edgeColour.g, edgeColour.b); 
  - borderColourRedSafe = new Color(edgeColourRedSafe.r, edgeColourRedSafe.g, edgeColourRedSafe.b);
  - borderColourGreenSafe = new Color(edgeColourGreenSafe.r, edgeColourGreenSafe.g, edgeColourGreenSafe.b);
  - borderColourBlueSafe = new Color(edgeColourBlueSafe.r, edgeColourBlueSafe.g, edgeColourBlueSafe.b);


- ROCK COLOURS (**SET NORMAL COLOUR**)
  - rockColour = new Color(117.0f / 255.0f, 95.0f / 255.0f, 43.0f / 255.0f); 
  - rockColourRedSafe = new Color(117.0f / 255.0f, 95.0f / 255.0f, 43.0f / 255.0f);
  - rockColourGreenSafe = new Color(61.0f / 255.0f, 61.0f / 255.0f, 61.0f / 255.0f);
  - rockColourBlueSafe = new Color(61.0f / 255.0f, 61.0f / 255.0f, 61.0f / 255.0f);


- ROCK DAMAGED COLOURS (**SET NORMAL COLOUR**)
  - rockDamagedColour = new Color(181.0f / 255.0f, 151.0f / 255.0f, 83.0f / 255.0f); 
  - rockDamagedColourRedSafe = new Color(181.0f / 255.0f, 151.0f / 255.0f, 83.0f / 255.0f);
  - rockDamagedColourGreenSafe = new Color(132.0f / 255.0f, 132.0f / 255.0f, 132.0f / 255.0f);
  - rockDamagedColourBlueSafe = new Color(132.0f / 255.0f, 132.0f / 255.0f, 132.0f / 255.0f); //


- CRYSTAL COLOURS (**SET NORMAL COLOUR**)
  - crystalColour = new Color(0.0f / 255.0f, 255.0f / 255.0f, 229.0f / 255.0f); 
  - crystalColourRedSafe = new Color(0.0f / 255.0f, 255.0f / 255.0f, 229.0f / 255.0f);
  - crystalColourGreenSafe = new Color(191.0f / 255.0f, 0.0f / 255.0f, 255.0f / 255.0f);
  - crystalColourBlueSafe = new Color(191.0f / 255.0f, 0.0f / 255.0f, 255.0f / 255.0f); //

- PICK UP COLOURS (**SET NORMAL COLOUR**)
  - pickUpColour = new Color(255.0f / 255.0f, 215.0f / 255.0f, 0.0f / 255.0f); 
  - pickUpColourRedSafe = new Color(255.0f / 255.0f, 215.0f / 255.0f, 0.0f / 255.0f);
  - pickUpColourGreenSafe = new Color(218.0f / 255.0f, 165.0f / 255.0f, 32.0f / 255.0f);
  - pickUpColourBlueSafe = new Color(218.0f / 255.0f, 165.0f / 255.0f, 32.0f / 255.0f); //


- BASIC MONSTER COLOURS (**SET NORMAL COLOUR**)
  - basicMonColour = new Color(226.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f); 
  - basicMonColourRedSafe = new Color(226.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f);
  - basicMonColourGreenSafe = new Color(87.0f / 255.0f, 155.0f / 255.0f, 0.0f / 255.0f);
  - basicMonColourBlueSafe = new Color(87.0f / 255.0f, 155.0f / 255.0f, 0.0f / 255.0f); //


- JUICY MONSTER COLOURS (**SET NORMAL COLOUR**)
  - juicyMonColour = new Color(87.0f / 255.0f, 155.0f / 255.0f, 0.0f / 255.0f);
  - juicyMonColourRedSafe = new Color(87.0f / 255.0f, 155.0f / 255.0f, 0.0f / 255.0f);
  - juicyMonColourGreenSafe = new Color(226.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f);
  - juicyMonColourBlueSafe = new Color(226.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f); //


- Chest and key colours (**SET NORMAL COLOUR**)
  - chestKeyColours = new Color[] { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta, Color.cyan }; 
  - chestKeyColoursRedSafe = new Color[] { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta, Color.cyan }; //
  - chestKeyColoursGreenSafe = new Color[] { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta, Color.cyan }; //
  - chestKeyColoursBlueSafe = new Color[] { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta, Color.cyan }; //


- UI COLOURS (**SET NORMAL COLOUR**)
  - UITextColour = new Color(255.0f / 255.0f, 254.0f / 255.0f, 239.0f / 255.0f); 
  - UITextColourRedSafe = new Color(255.0f / 255.0f, 254.0f / 255.0f, 239.0f / 255.0f);
  - UITextColourGreenSafe = new Color(255.0f / 255.0f, 188.0f / 255.0f, 204.0f / 255.0f);
  - UITextColourBlueSafe = new Color(255.0f / 255.0f, 188.0f / 255.0f, 204.0f / 255.0f); //


- UI BACKGROUND COLOURS (**SET NORMAL COLOUR**)
  - UIBackgroundColour = new Color(33.0f / 255.0f, 22.0f / 255.0f, 0.0f / 255.0f); 
  - UIBackgroundColourRedSafe = new Color(33.0f / 255.0f, 22.0f / 255.0f, 0.0f / 255.0f);
  - UIBackgroundColourGreenSafe = new Color(9.0f / 255.0f, 0.0f / 255.0f, 56.0f / 255.0f);
  - UIBackgroundColourBlueSafe = new Color(9.0f / 255.0f, 0.0f / 255.0f, 56.0f / 255.0f); //
