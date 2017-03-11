using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLazerShot : MonoBehaviour
{

    public GameObject EnemyLazer;
    public Transform EnemyLazerSpawn;
    public float counter;
    public float shootTime;
    public float minRange;
    public float maxRange;

    // Use this for initialization
    void Start()
    {
        NewShootTime();
    }

    void Update()
    {
        counter += Time.deltaTime;
        if(counter > shootTime)
        {
            Instantiate(EnemyLazer, EnemyLazerSpawn.position, EnemyLazerSpawn.rotation);
            NewShootTime();
        }

    }
    void NewShootTime()
    {
        counter = 0;
        shootTime = Random.Range(minRange, maxRange);
    }
}
