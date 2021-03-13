using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountSystem : MonoBehaviour
{
public Text PaperCounter;
public Text CanCounter;

public void SetPaperCount(int count)
{
PaperCounter.text=count.ToString();
}
public void SetCanCount(int count)
{
CanCounter.text=count.ToString();
}


}
