using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
public GameObject EnemyPrefab;
    public bool Alive;
    private bool Delay = true;
    private GameObject EnemyInst;
    private float starttime = 2f;
    public float TimeInterval = 2f;

    private void Update()
    {
        if (!Alive)
        {
            Delay=true;
            WaitTime();
            Alive = true;
        }

        if (EnemyInst == null)
        {
            Alive = false;
        }
    }

    void WaitTime()
    {
        if (Delay)
        {
            
            if (starttime <= 0f)
            {
                Delay = false;
                Instantiation();
                starttime=TimeInterval;
            
            }
            else
            {
                starttime -= Time.deltaTime;
            }
        }

    }

    void Instantiation()
    {
        EnemyInst = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
    }
}



