using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class DangKyAcc : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;
    public TextMeshProUGUI thongbao;

    public GameObject dangKyCanvas; // Canvas đăng ký
    public GameObject dangNhapCanvas; // Canvas đăng nhập
    public void DangKysButton()
    {
        StartCoroutine(DangKy());
    }

    IEnumerator DangKy()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", username.text);
        form.AddField("passwd", password.text);

        UnityWebRequest www = UnityWebRequest.Post("https://fpl.expvn.com/dangky.php", form);
        yield return www.SendWebRequest();

        if (!www.isDone)
        {
            thongbao.text = "Ket noi khong thanh cong...";
        }
        else
        {
            string get = www.downloadHandler.text;

            switch (get)
            {
                case "exist": thongbao.text = "tài khoản đã tồn tại..."; 
                    break;
                case "Ok": thongbao.text = "đăng ký thành công";

                    yield return new WaitForSeconds(0.1f); // Đợi 0.1 giây để người dùng thấy thông báo thành công
                    dangKyCanvas.SetActive(false); // Ẩn canvas đăng ký
                    dangNhapCanvas.SetActive(true); // Hiện canvas đăng nhập
                    break;
                case "ERROR": thongbao.text = "đăng ký không thành công";
                    break;
                case "Lỗi...": thongbao.text = "không kết nối được server";
                    break;

            }
        }
    }
}
