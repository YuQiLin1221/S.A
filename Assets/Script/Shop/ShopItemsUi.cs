using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemsUi : MonoBehaviour
{
    public Text priceText;
    public Image hub;
    public Button btn;

    public void UpdateUi(ShopItems items, int shopItemId)
    {
        if (items == null ) 
        { 
            return; 
        }
        if (hub)
        {
            hub.sprite = items.hub;
        }
        
    }
}
