using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropControll : MonoBehaviour
{
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
    }
}
