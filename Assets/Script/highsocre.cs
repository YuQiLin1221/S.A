using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text highScoreText; // Kéo và th? UI Text element vào ?ây
    private int highScore = 0;
    private int goldScore = 0;
    private int diamondScore = 0;

    private void Start()
    {
        // Load high score, gold score, and diamond score from player prefs or initialize them
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        goldScore = PlayerPrefs.GetInt("GoldScore", 0);
        diamondScore = PlayerPrefs.GetInt("DiamondScore", 0);
        UpdateHighScoreText();
    }

    public void UpdateHighScore(int newScore, bool isGold, bool isDiamond)
    {
        if (newScore > highScore)
        {
            highScore = newScore;
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        if (isGold)
        {
            goldScore += newScore;
            PlayerPrefs.SetInt("GoldScore", goldScore);
        }

        if (isDiamond)
        {
            diamondScore += newScore;
            PlayerPrefs.SetInt("DiamondScore", diamondScore);
        }

        UpdateHighScoreText();
    }

    private void UpdateHighScoreText()
    {
        highScoreText.text = $"High Score: {highScore}\nGold: {goldScore}\nDiamond: {diamondScore}";
    }
}
