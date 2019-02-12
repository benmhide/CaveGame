using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // OnTriggerExit is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // If the other collider is the player
        if (other.gameObject.tag == Tags.monsterTag)
        {
            other.gameObject.GetComponent<MonsterMovement>().attack = true;
        }
    }

    // OnTriggerExit is called when the Collider other exits the trigger
    void OnTriggerExit(Collider other)
    {
        // If the other collider is the player
        if (other.gameObject.tag == Tags.monsterTag)
        {
            other.gameObject.GetComponent<MonsterMovement>().attack = false;
        }
    }
}
