using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropControll : MonoBehaviour
{
    public GameObject Plane;

    public Transform SpawnA;
    public Transform SpawnB;
    public Transform SpawnC;
    public Transform SpawnD;
    public Transform SpawnE;

    public float SpawnTime;
    public float RandomizeSpawn;

    void Start()
    {
        
    }
    
    void Update()
    {
        SpawnTime += Time.deltaTime;

        if(SpawnTime > 10)
        {
            RandomizeSpawn = Random.value;
            if(RandomizeSpawn >= 0 && RandomizeSpawn < 0.16)
            {
                Instantiate(Plane ,SpawnA.position, SpawnA.rotation);
            }            
        }

        if(SpawnTime > 10.1)
        {
            SpawnTime = 0;
        }

    }
}
