using UnityEngine;
using TMPro;
using UnityEngine.UI; // Đừng quên thêm thư viện này để sử dụng Button  

public class PhanThuong : MonoBehaviour
{
    public GameManager gameManager; // Tham chiếu đến GameManager  
    public int goldAmount; // Số lượng vàng  
    public int diamondAmount; // Số lượng kim cương  
    public int lightAmount;
    public int keyAmount;
    public TextMeshProUGUI goldText; // Tham chiếu tới TextMeshPro UI cho vàng  
    public TextMeshProUGUI diamondText; // Tham chiếu tới TextMeshPro UI cho kim cương  
    public TextMeshProUGUI lightText;
    public TextMeshProUGUI keyText;
    public GameObject objectToActivate; // Tham chiếu tới đối tượng cần bật lên  
    public Button activateButton; // Tham chiếu tới nút kích hoạt  

    
    void Start()
    {
        // Khởi tạo vàng và kim cương ngẫu nhiên  
        goldAmount = Random.Range(0, 100); // Cộng vàng ngẫu nhiên từ 0 đến 99  
        diamondAmount = Random.Range(0, 50); // Cộng kim cương ngẫu nhiên từ 0 đến 49  
        lightAmount = Random.Range(0, 5);
        keyAmount = Random.Range(0, 5);

        
        // Hiển thị số lượng vàng và kim cương  
        UpdateUI();

        // Đăng ký sự kiện cho nút  
        activateButton.onClick.AddListener(OnLevelComplete);
    }

    // Phương thức cập nhật UI  
    void UpdateUI()
    {
        goldText.text = "Gold: " + goldAmount.ToString();
        diamondText.text = "Diamonds: " + diamondAmount.ToString();
        lightText.text = "Light: " + lightAmount.ToString();
        keyText.text = "Key: " + keyAmount.ToString();
    }

    // Phương thức gọi khi nhấn nút để bật đối tượng  
    void OnLevelComplete()
    {
        // Bật đối tượng khi qua màn.  
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
            gameManager.AddGold(goldAmount);
            gameManager.AddDiamonds(diamondAmount);
            gameManager.AddLight(lightAmount);
            gameManager.AddKey(keyAmount);
            Debug.Log($"Đã cộng {goldAmount} vàng và {diamondAmount} kim cương!");
        }
    }
}