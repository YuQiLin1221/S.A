using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class WinLose : MonoBehaviour
{
    public GameObject Win, Lose, Backgorund;
   
    public void win()
    {
        Win.SetActive(!Win.activeSelf);
        
        Backgorund.SetActive(false);
        
        
        
    }
    public void lose()
    {
        Lose.SetActive(!Win.activeSelf);
        Backgorund.SetActive(false);
        
    }
    public void replay()
    {
        Lose.SetActive(false);
        Backgorund.SetActive(true);
        
    }
}
