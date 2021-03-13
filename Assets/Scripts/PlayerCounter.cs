using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCounter : MonoBehaviour
{
public CountSystem Count;
public int PaperCount=0;
public int CanCount=0;
private void Update()
    {
    Count.SetCanCount(CanCount);
    Count.SetPaperCount(PaperCount);
    }

}
