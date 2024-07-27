using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhanThuong : MonoBehaviour
{
    public int gold = 0;
    public int diamond = 0;
    public int key = 0;
    public int lightBuld = 0;

    public void ThuongWin()
    {
        goldRanDom();
        diamondR();
        keyRanDom();
        lightBuldRanDom();
    }

    public void ThuongLose()
    {
        goldRanDom();
        diamondR();
    }
        void goldRanDom()
        {
            int randomgold = Random.Range(100, 200);
            gold += randomgold;
        }

        void diamondR()
        {
            int RdDiamond = Random.Range(1, 20);
            diamond += RdDiamond;
        }
        void keyRanDom()
        {
            int RdKey = Random.Range(1, 3);
            key += RdKey;
        }
        void lightBuldRanDom()
        {
            int RdLightBuld = Random.Range(1, 2);
            diamond += RdLightBuld;
        }
    
}
