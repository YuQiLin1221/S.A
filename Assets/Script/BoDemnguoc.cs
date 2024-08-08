using TMPro;
using UnityEngine;
using UnityEngine.UI; // Đảm bảo thêm dòng này nếu bạn sử dụng UI  

public class BoDemnguoc : MonoBehaviour
{
    public float timeRemaining = 30; // Thời gian đếm ngược (30 giây)  
    public bool timerIsRunning = false;
    public GameObject lose, Backgorund; // hiển thị màn hình thua khi hết thời gian 
    public TextMeshProUGUI timeText; // Tham chiếu đến TextMesh Pro  


    private void Start()
    {
        // Bắt đầu bộ đếm  
        timerIsRunning = true;
    }

    private void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerUI();
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                TimeIsUp();
            }
        }
    }

    private void UpdateTimerUI()
    {
        // Cập nhật hiển thị thời gian  
        timeText.text = Mathf.Round(timeRemaining).ToString();
    }

    private void TimeIsUp()
    {
        // Hành động khi thời gian hết  
        Debug.Log("Thời gian đã hết!");
        // Thực hiện hành động khác như kết thúc trò chơi hoặc chuyển cảnh  
        lose.SetActive(!lose.activeSelf);
        Backgorund.SetActive(false);
    }
}