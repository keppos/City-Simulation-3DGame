using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeAlarm : MonoBehaviour
{
    [SerializeField] ParticleSystem Smoke = null;
    // Start is called before the first frame update
    void Start()
    {
        Smoke = GetComponent<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {

        // B�rjar simulera r�k vid knapptryck G
        if (Input.GetKeyDown(KeyCode.G))
        {
            Smoke.Play();
        }
        
    }
}
