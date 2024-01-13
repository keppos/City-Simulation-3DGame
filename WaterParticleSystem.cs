using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterParticleSystem : MonoBehaviour
{
    public GameObject waterParticlePrefab;
    public float LifeTime;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject waterParticle = Instantiate(waterParticlePrefab, transform.position, transform.rotation);
        Destroy(waterParticle, LifeTime);
        waterParticle.GetComponent<Rigidbody>().AddRelativeForce(Random.Range(4, 7), Random.Range(-2, 2), Random.Range(-2, 2), ForceMode.Impulse);

    }
}
