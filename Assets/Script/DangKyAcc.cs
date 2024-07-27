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
                    break;
                case "ERROR": thongbao.text = "đăng ký không thành công";
                    break;
                case "Lỗi...": thongbao.text = "không kết nối được server";
                    break;

            }
        }
    }
}
