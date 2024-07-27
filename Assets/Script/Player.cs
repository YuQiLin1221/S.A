using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text gold, diamond, key, lightBuld;
    public LuuDiem vp;
    public WinLose W;
    // Start is called before the first frame update
    void Start()
    {
        gold.text = Convert.ToString("0") + vp.GoldScore;
        diamond.text = Convert.ToString("0") +vp.DiamondScore;
        key.text = Convert.ToString("0") +vp.KeyScore;
        lightBuld.text = Convert.ToString("0") + vp.LightBuldScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
