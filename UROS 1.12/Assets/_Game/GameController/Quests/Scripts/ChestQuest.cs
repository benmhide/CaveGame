#pragma warning disable 0414
using UnityEngine;

// Open chests quest
public class ChestQuest : IQuest
{
    ///////////////////////////Variables////////////////////////////

    // Open chest quest items
    public GameObject chestGO;
    public GameObject keyGO;
    bool questComplete = false;
    bool questInitialised = false;
    string questName = StaticStrings.chestQuestName;
    string questText = StaticStrings.chestQuestText;
    string questTextCompleted = StaticStrings.chestQuestTextCompleted;

    // References
    public QuestManager questManager;
    public Map map;
    public HUD hud;

    ///////////////////////End of Variables/////////////////////////



    ///////////////////////////Functions////////////////////////////

    // Initialises gamemode
    public void Init()
    {
        // References
        questManager = GameObject.FindGameObjectWithTag(Tags.gameControllerTag).GetComponent<QuestManager>();
        map = GameObject.FindGameObjectWithTag(Tags.gameControllerTag).GetComponent<Map>();
        hud = GameObject.FindGameObjectWithTag(Tags.uiTag).GetComponent<HUD>();

        // Quest initialised
        questInitialised = true;

        // Event/callbacks
        Chest.onChestOpened += ChestOpened;
        Key.onKeyCollected += KeyCollected;
        Debug.Log("Open chests quest initialised!");

        // Count the total game chests and keys
        questManager.SetTotalChestsAndKeys();

        // Load the prefabs
        chestGO = questManager.chest;
        keyGO = questManager.key;

        // Set the quest text
        hud.SetQuestProgressText(questManager.ChestsOpened() + "/" + questManager.TotalChests());
        hud.SetQuestProgressItem(questManager.chestSprite);
    }

    // Chest has been opened
    public void ChestOpened(GameObject chest)
    {
        Debug.Log("Chest opened!");

        // Count the open chest 
        questManager.ChestOpened(chest.GetComponent<Chest>().Index());

        // Set the screen ui and destroy the key
        hud.SetQuestProgressText(questManager.ChestsOpened() + "/" + questManager.TotalChests());

        // Remove the key from the hud and destroy 
        hud.RemoveKey(chest.GetComponent<Chest>().GetKey().GetHUDItemKey(), chest.GetComponent<Chest>().GetKey().GetHUDItemArtefact());
        chest.GetComponent<Chest>().GetKey().DestroyKey();

        // If the chests have all been opened
        if (questManager.AllChestsOpened())
        {
            questComplete = true;
            Debug.Log("Open chests quest complete");
        }
    }

    // Key has been collected
    public void KeyCollected(GameObject key)
    {
        Debug.Log("Key collected!");

        // Count the collected key 
        questManager.KeyCollected(key.GetComponent<Key>().Index());

        // Set the screen ui
        hud.AddKey(key.GetComponent<Key>().GetHUDItemKey(), key.GetComponent<Key>().GetColour());
    }

    // Generates quest items
    public void GenerateQuestItems()
    {
        // Loop through all chests
        for (int i = 0; i < questManager.TotalChests(); i++)
        {
            // Instatiate the monsters and position in the map
            GameObject chest = Object.Instantiate(chestGO, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag(Tags.objectiveTag).transform) as GameObject;

            // Set chest position
            map.PositionChestInRock(chest);
            chest.GetComponent<Chest>().Index(GameDataManager.instance.RecordChestPosition(chest.transform.position));

            // Instatiate the key and position in the map
            GameObject key = Object.Instantiate(keyGO, Vector3.zero, keyGO.transform.rotation, GameObject.FindGameObjectWithTag(Tags.objectiveTag).transform) as GameObject;

            // Position the key
            map.RandomPosition(key);

            // Set the key and chest gameobject
            key.GetComponent<Key>().SetChest(chest);
            chest.GetComponent<Chest>().SetKey(key);

            // Set colors
            key.GetComponent<Key>().SetColour(Colours.chestKeyColours[i]);
            chest.GetComponent<Chest>().SetColour(Colours.chestKeyColours[i]);

            // Set the key item
            key.GetComponent<Key>().SetHUDItem(i, questManager.keySprite, questManager.artefacts[i]);

            // Place the key
            PlaceKey(key, chest);
        }
    }

    // Place the key
    void PlaceKey(GameObject key, GameObject chest)
    {
        // Distance from key to chest
        float dist = Vector3.Distance(key.transform.position, chest.transform.position);

        // Distance from player to key
        float distToPlayer = Vector3.Distance(key.transform.position, GameObject.FindGameObjectWithTag(Tags.playerTag).transform.position);

        // Has the key been placed
        bool keyPlaced = false;

        // While the key has not been placeed
        while (!keyPlaced)
        {
            // If the distance from key to chest is inbetween the max and min distance place the key
            if (dist < questManager.maxKeyToChestDist /*+ 1 && dist > questManager.maxKeyToChestDist*/ && distToPlayer > questManager.minKeyToPlayerDist)
            {
                // Place the key
                keyPlaced = true;
                key.transform.position = new Vector3((int)key.transform.position.x, key.transform.position.y, (int)key.transform.position.z);
                key.GetComponent<Key>().Index(GameDataManager.instance.RecordKeyPosition(key.transform.position));
            }

            // Else find a new location for the key
            else
            {
                // Choose a new random key position
                map.RandomPosition(key);
                dist = Vector3.Distance(key.transform.position, chest.transform.position);
            }
        }

        // Open the grid cube for the key and set it as empty
        CubeData cubeData = map.GridCubeArray()[(int)key.transform.position.x, (int)key.transform.position.z].GetComponent<CubeData>();

        // Open the grid cube - empty cube
        cubeData.OpenGridCube();
    }

    //////////////////////////Set and Gets//////////////////////////

    public bool QuestComplete()
    {
        return questComplete;
    }

    public string QuestName()
    {
        return questName;
    }

    public string QuestText()
    {
        return questText;
    }

    public string QuestTextCompleted()
    {
        return questTextCompleted;
    }

    ///////////////////////End of Functions/////////////////////////
}