# CaveGame
Procedurally generate cave adventure game created for the UROS project at University of Lincoln.

# Game features:
-	Procedurally generated map / caves
o	Rock cubes – less juicy / fewer hits to destroy
o	Crystal cubes – More juicy more hits to destroy
-	Quest system feat. Four quests
o	Collect pickups (gold)
o	Search for keys to open chests to collect artefacts
o	Kill monsters
o	Exit the caves (complete game)
o	Hidden quest – Save/kill civilian (male/female/cat)
-	Selectable font sizes for in game text
-	Selectable colour settings for game
o	Normal mode
o	Red colour blind mode
o	Green colour blind mode
o	Blue colour blind mode
-	Selectable character
o	Male
o	Female
-	Two monster types
o	Basic monster (less juicy damaged effects and shrinks on death / no death particles)
o	Juicy monsters (increased juiciness when damaging / killing monster)
-	Game and settings data collection via firebase. Collected data detailed below in firebase data section.
-	Playable character has two actions
o	Digging through rock / crystal cubes – attacking monsters using pickaxe
o	Dropping TNT to destroy rock / crystal cubes – killing monsters

# Firebase Data Collected

# Colour settings
To modify colour settings the values sorted in the Colours C# file need to be modified.
The Colours C# file is located in ….
Colours used in the game can be set for all colour blind settings and normal colour settings. Colours defined in this file will automatically be used during the game. The Unity colours used in this file are clearly named and should be easy to modify with any RGBA values.
Colours are as follows:
