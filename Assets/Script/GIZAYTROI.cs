using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GIZAYTROI : MonoBehaviour
{
    public Canvas startCanvas; // Canvas 'start'
    public Canvas loginCanvas; // Canvas 'đăng nhập'
    public Canvas registerCanvas; // Canvas 'đăng ký'

    public Button loginButton; // Button 'đăng nhập'
    public Button registerButton; // Button 'đăng ký'
    public Button backButtonLogin; // Button 'quay lại' trên canvas 'đăng nhập'
    public Button backButtonRegister; // Button 'quay lại' trên canvas 'đăng ký'

    private Vector3 originalScale;
    private bool isScaling = false;

    private void Start()
    {
        // Lưu lại kích thước gốc của các nút
        originalScale = loginButton.transform.localScale;

        // Thêm sự kiện click cho các nút
        loginButton.onClick.AddListener(() => OnButtonClick(loginCanvas));
        registerButton.onClick.AddListener(() => OnButtonClick(registerCanvas));
        backButtonLogin.onClick.AddListener(() => GoBackToStart());
        backButtonRegister.onClick.AddListener(() => GoBackToStart());

        // Đặt canvas hiện tại là startCanvas
        startCanvas.gameObject.SetActive(true);
        loginCanvas.gameObject.SetActive(false);
        registerCanvas.gameObject.SetActive(false);
    }

    
    private void OnButtonClick(Canvas targetCanvas)
    {
        // Phóng to nút đang được nhấn
        if (!isScaling)
        {
            StartCoroutine(ScaleButton(loginButton));
            StartCoroutine(ScaleButton(registerButton));
        }

        // Hiện canvas tương ứng và ẩn canvas 'start'
        startCanvas.gameObject.SetActive(false);
        targetCanvas.gameObject.SetActive(true);
    }

    private System.Collections.IEnumerator ScaleButton(Button button)
    {
        isScaling = true;
        Vector3 targetScale = originalScale * 1.03f;
        float duration = 0.2f;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            button.transform.localScale = Vector3.Lerp(originalScale, targetScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        button.transform.localScale = targetScale;

        // Quay lại kích thước gốc
        elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            button.transform.localScale = Vector3.Lerp(targetScale, originalScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        button.transform.localScale = originalScale;
        isScaling = false;
    }

    private void GoBackToStart()
    {
        // Trở về canvas 'start' từ bất kỳ canvas nào khác
        startCanvas.gameObject.SetActive(true);
        loginCanvas.gameObject.SetActive(false);
        registerCanvas.gameObject.SetActive(false);
    }
}
