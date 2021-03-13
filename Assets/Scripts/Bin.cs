using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{
private bool somebool;
    private Collider2D othercol;
    
    private void Update()
    {
        Emptying();
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        somebool = true;
        othercol = other;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        somebool = false;
        othercol = null;
    }

    void Emptying()
    {
        if (somebool)
        {
            
            if (othercol.CompareTag("Player"))
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                othercol.GetComponent<PlayerCounter>().PaperCount=0;
                othercol.GetComponent<PlayerCounter>().CanCount=0;                    
                }
            }
        }
    }

}
