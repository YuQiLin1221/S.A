using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class  PlayerPref: MonoBehaviour
{
    public TextMeshProUGUI goldText;  // TMP để hiển thị số lượng vàng
    public TextMeshProUGUI kcText;    // TMP để hiển thị số lượng kim cương
    public TextMeshProUGUI lightText;  // TMP để hiển thị số lượng light
    public TextMeshProUGUI keyText;    // TMP để hiển thị số lượng key

    private int gold;
    private int kc;
    private int lights;
    private int key;
    public PhanThuong w;
    void Start()
    {
        // Truy xuất giá trị từ PlayerPrefs hoặc thiết lập giá trị mặc định
        gold = PlayerPrefs.GetInt("Gold", 0);
        kc = PlayerPrefs.GetInt("KC", 0);
        lights = PlayerPrefs.GetInt("Light", 0);
        key = PlayerPrefs.GetInt("Key", 0);

        // Cập nhật hiển thị
        UpdateCurrencyDisplay();
    }

    public void add()
    {
        //
        gold += w.goldAmount;
        PlayerPrefs.SetInt("Gold", gold);
        PlayerPrefs.Save();
        UpdateCurrencyDisplay();
        //
        kc += w.diamondAmount;
        PlayerPrefs.SetInt("Kc", kc);
        PlayerPrefs.Save();
        UpdateCurrencyDisplay();
        //
        lights += w.lightAmount;
        PlayerPrefs.SetInt("Light",lights);
        PlayerPrefs.Save();
        UpdateCurrencyDisplay();
        //
        key += w.keyAmount;
        PlayerPrefs.SetInt("Key", key);
        PlayerPrefs.Save();
        UpdateCurrencyDisplay();
    }
    // Hàm cập nhật hiển thị
    private void UpdateCurrencyDisplay()
    {
        goldText.text = "Gold: " + gold.ToString();
        kcText.text = "KC: " + kc.ToString();
        lightText.text = "Light: " + lights.ToString();
        keyText.text = "Key: " + key.ToString();
    }
}
