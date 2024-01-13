using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNPC : MonoBehaviour
{

    public GameObject NPCPrefab;
    public int NPCCount;

    void Start()
    {
        
        // Spawnar in set amount av NPC clones
        for (int i = 0; i < NPCCount; i++)
        {
            GameObject NPC = Instantiate(NPCPrefab, transform.position, transform.rotation);
        }

    }
}
