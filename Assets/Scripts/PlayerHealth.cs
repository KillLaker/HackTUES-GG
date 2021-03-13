using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{

public HealthBar HP;
public Camera MainCamera;
public void LoseHealth(int Damage)
    {
        HP.TakeDamage(Damage);
    }
private void Update()
    {
        if(HP.health<=0)
        {

            Destroy(this.gameObject);
            MainCamera.GetComponent<CameraFollow>().enabled = false;
            SceneManager.LoadScene("Start Menu");
        }
    }
}