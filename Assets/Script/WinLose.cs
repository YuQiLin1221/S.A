using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class WinLose : MonoBehaviour
{
    public GameObject Win, Lose, Backgorund, hienThi;
   
    public void win()
    {
        Win.SetActive(!Win.activeSelf);
        
        Backgorund.SetActive(false);
        hienThi.SetActive(false);
        
        
    }
    public void lose()
    {
        Lose.SetActive(!Win.activeSelf);
        Backgorund.SetActive(false);
        hienThi.SetActive(false);
    }
    public void replay()
    {
        Lose.SetActive(false);
        Backgorund.SetActive(true);
        hienThi.SetActive(true );
    }
}
