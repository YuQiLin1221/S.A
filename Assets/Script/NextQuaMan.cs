using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextQuaMan : MonoBehaviour
{
   
    public void NextLV2()
    {
        SceneManager.LoadScene(2);
    }
    public void NextLV3()
    {
        SceneManager.LoadScene(3);
    }
}
