using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numberOfHumans;
    public float waitTime;
    public GameObject humanSpawn;

    void Start()
    {
        StartCoroutine(SpawnHumans());
        
    }

    IEnumerator SpawnHumans()
    {
        while (numberOfHumans > 0)
        {
            Instantiate(humanSpawn, transform.position, transform.rotation);
            yield return new WaitForSeconds(waitTime);
            numberOfHumans--;
        }
    }


}
