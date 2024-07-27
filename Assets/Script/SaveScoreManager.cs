using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class SaveScoreManager : MonoBehaviour
{

    public TMP_InputField playerNameInput; // InputField để nhập tên người chơi
    public PlayerScoreData playerScoreData; // ScriptableObject lưu điểm số
    public TextMeshProUGUI thongbao; // Hiển thị thông báo
    private string filePath; // Đường dẫn file lưu thông tin người chơi


    // Start is called before the first frame update
    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "playerData.txt");
    }

    public void SaveScore()
    {
        string playerName = playerNameInput.text;
        int score = playerScoreData.score;

        string user = PlayerPrefs.GetString("user");
        string passwd = PlayerPrefs.GetString("passwd");
        string token = PlayerPrefs.GetString("token");

        SavePlayerData(user, passwd, token, playerName, score);
    }

    private void SavePlayerData(string user, string passwd, string token, string playerName, int score)
    {
        string data = $"_user: {user}\n_passwd: {passwd}\n_Token: {token}\n_playerName: {playerName}\n_score: {score}";
        File.WriteAllText(filePath, data);
        thongbao.text = "Dữ liệu đã được lưu vào " + filePath;
        Debug.Log("Player data saved to " + filePath);
    }
}
