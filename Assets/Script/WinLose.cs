using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using Unity.VisualScripting;

public class WinLose : MonoBehaviour
{
    public GameObject Win, Lose, Backgorund, setting;
   
    public void win()
    {
        Win.SetActive(!Win.activeSelf);
        
        Backgorund.SetActive(false);
        
    }
    public void lose()
    {
        Lose.SetActive(!Lose.activeSelf);
        Backgorund.SetActive(false);
        
    }
    public void replay()
    { 
        Backgorund.SetActive(true);
        Win.SetActive(false);
        Lose.SetActive(false);
    }

    public void exitBG()
    {
        setting.SetActive(!setting.activeSelf);
        Backgorund.SetActive(false);
    }

    public void exitST()
    {
        setting.SetActive(false);
        Backgorund.SetActive(true);
    }
}
