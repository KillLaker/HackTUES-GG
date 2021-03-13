using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
public GameObject Enemy;
public bool isCan;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(Enemy.gameObject);
            if(isCan)
            {
            other.gameObject.GetComponent<PlayerCounter>().CanCount+=1;
            }
            else other.gameObject.GetComponent<PlayerCounter>().PaperCount+=1;
        }
    }

}
