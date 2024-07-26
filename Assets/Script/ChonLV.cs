using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChonLV : MonoBehaviour
{
    public GameObject PanelMenu, ButtonM1, ButtonM2, ButtonM3, Text;
    // Start is called before the first frame update
    void Start()
    {
        PanelMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       
        ButtonM1.SetActive(true); 
        
    }
}
