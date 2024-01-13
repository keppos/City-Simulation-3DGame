using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject humanPrefab;
    public int humanAmount;



    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < humanAmount; i++)
        {
            GameObject Human = Instantiate(humanPrefab, transform.position, transform.rotation);
        }

    }
}
