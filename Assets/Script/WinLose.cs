using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public GameObject panelWin, panelLose;
    

    public void panelwin()
    {
        panelWin.SetActive(!panelWin.activeSelf);
    }
    public void panellose()
    {
        panelLose.SetActive(!panelLose.activeSelf);
    }
    void Update()
    {
        
    }
}
