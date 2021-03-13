using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
public HealthBar HP;
public Camera MainCamera;
private bool isDestroyed;
public float timeInterval;
private float starttime;
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("KillPlayer"))
        {
             
            if (starttime <= 0f)
            {
                starttime = timeInterval;
                HP.TakeDamage(1);
            }
            else
            {
                starttime -= Time.deltaTime;
            }

        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("KillPlayer"))
        {
          HP.TakeDamage(1);
          starttime=timeInterval;
        }

 
    }

    private void Update()
    {
        if(HP.health<=0)
        {
            Destroy(this.gameObject);
            isDestroyed=true;
        }
        if(isDestroyed)
        {
            MainCamera.GetComponent<CameraFollow>().enabled = false;

        }
    }
}
