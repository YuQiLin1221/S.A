using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using Unity.VisualScripting;
using UnityEngine.UI;

public class WinLose : MonoBehaviour
{
    public GameObject Win, Lose, Backgorund, setting, c2, c3, c4, c5;
   
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
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        c5.SetActive(false);

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
    public void man2()
    {
        c2.SetActive(!c2.activeSelf);
        Backgorund.SetActive(false);

    }
    public void man3()
    {
        c3.SetActive(!c3.activeSelf);
        c2.SetActive(false);
        Backgorund.SetActive(false);

    }
    public void man4()
    {
        c4.SetActive(!c4.activeSelf);
        c2.SetActive(false);
        c3.SetActive(false);
        Backgorund.SetActive(false);

    }
    public void man5()
    {
        c5.SetActive(!c5.activeSelf);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        Backgorund.SetActive(false);

    }

}
