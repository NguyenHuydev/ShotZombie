using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{

    GameObject[] spawnpoint;
    public GameObject zombie;
    
    public float spawnTimeMin = 0.2f;
    public float spawnTimeMax = 1;
    private float lastTimeSpawn;
    private float spawnTime;


    void updateTimeSpawn()
    {
        lastTimeSpawn = Time.time;
        spawnTime = Random.Range(spawnTimeMin, spawnTimeMax);
    }


    void SpawnZombie()
    {
        int point = Random.Range(0, spawnpoint.Length);
        float position = Random.Range(-25.5f, 25.5f);
        Vector3 positionSpawn = new Vector3(position, 0, 23);
        // z =23, y = 0, x =-25,5->25,5
        //Instantiate(zombie, spawnpoint[point].transform.position, Quaternion.identity);
        Instantiate(zombie, positionSpawn, Quaternion.identity);
        updateTimeSpawn();
    }


    // Start is called before the first frame update
    void Start()
    {
        spawnpoint = GameObject.FindGameObjectsWithTag ("SpawnPoint");
        updateTimeSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= lastTimeSpawn + spawnTime)
        {
            SpawnZombie();
        }
        
    }


}
