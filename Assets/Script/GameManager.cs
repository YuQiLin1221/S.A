using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    private int gold;
    private int Kc;
    private int Light;
    private int Key;

    private void Start()
    {
        score = 0;
        gold = 0;
        Kc = 0;
        Light = 0;
        Key = 0;
        Debug.Log("Điểm số bắt đầu: " + score);
        Debug.Log("Vàng bắt đầu: " + gold);
        Debug.Log("Kim cương bắt đầu: " + Kc);
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Điểm số hiện tại: " + score);
    }

    public void AddGold(int amount)
    {
        gold += amount;
        Debug.Log("Vàng hiện tại: " + gold);
    }

    public void AddDiamonds(int amount)
    {
        Kc += amount;
        Debug.Log("Kim cương hiện tại: " + Kc);
    }
    public void AddLight(int amount)
    {
        Light += amount;
        Debug.Log("Den hiện tại: " + Light);
    }
    public void AddKey(int amount)
    {
        Key += amount;
        Debug.Log("Chia khoa hiện tại: " + Key);
    }
}