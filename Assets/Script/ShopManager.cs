using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShopManager : MonoBehaviour
{

    public ShopItems[] items;

    private void Start()
    {
        if(items == null || items.Length <= 0 )
        {
            return;
        }

        for (int i = 0; i < items.Length; i++)
        {
            var item = items[i];
            //if (item != null)
            //{
            //}
        }
    }
}

[System.Serializable]
public class ShopItems
{
    public int Price;
    public Sprite hub;
}
