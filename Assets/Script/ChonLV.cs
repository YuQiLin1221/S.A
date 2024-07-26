using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class ChonLV : MonoBehaviour
{
    public GameObject Map, ManHinhChinh, hienthi;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void Bat()
    {
        Map.SetActive(!Map.activeSelf);
        ManHinhChinh.SetActive(false);
        hienthi.SetActive(false);
    }

    public void exit()
    {
        Map.SetActive(!Map.activeSelf);
        ManHinhChinh.SetActive(true);
        hienthi.SetActive(true);
    }
    void Update()
    {
       
      
        
    }
}
