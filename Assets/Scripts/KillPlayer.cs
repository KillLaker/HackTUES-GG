using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
public int Damage;
    private float starttime;
    public float timeInterval;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().LoseHealth(Damage);
            starttime=timeInterval;
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            if (starttime <= 0f)
            {
                starttime = timeInterval;
                other.GetComponent<PlayerHealth>().LoseHealth(Damage);
            }
            else
            {
                starttime -= Time.deltaTime;
            }

        }
    }

}
