using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
public GameObject EnemyPrefab;
    public bool Alive;
    private GameObject EnemyInst;
    private void Update()
    {
        if (Alive)
        {
            EnemyInst = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
            Alive = false;
        }

        if (EnemyInst == null)
        {
            Alive = true;
        }

    }
 
}



