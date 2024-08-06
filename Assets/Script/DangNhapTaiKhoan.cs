using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class DangNhapTaiKhoan : MonoBehaviour
{
    public TMP_InputField user;
    public TMP_InputField passwd;
    public TextMeshProUGUI thongbao;
    public GameObject InforMain;
    public GameObject dangnhap;
    //public GameObject saveScorePanel; // Giao diện nhập tên và lưu điểm

    public void DangNhapButton()
    {
        StartCoroutine(DangNhap());
    }

    IEnumerator DangNhap()
    {
        WWWForm dataForm = new WWWForm();
        dataForm.AddField("user", user.text);
        dataForm.AddField("passwd", passwd.text);

        UnityWebRequest www = UnityWebRequest.Post("https://fpl.expvn.com/dangnhap.php", dataForm);
        yield return www.SendWebRequest();

        if (!www.isDone)
        {
            thongbao.text = "Ket noi khong thanh cong...";
        }
        else
        {
            string get = www.downloadHandler.text;

            if (get == "emty")
            {
                thongbao.text = "Vui lòng nhập đầy đủ thông tin đăng nhập";
            }else if (get == "" || get == null)
            {
                thongbao.text = "Tài khoản hoặc mật khẩu không chính xác";
            }else if (get.Contains("Lỗi"))
            {
                thongbao.text = "Không kết nối được tới server";
            }
            else
            {
                thongbao.text = "Đăng nhập thành công";

                PlayerPrefs.SetString("token", get);
                PlayerPrefs.SetString("user", user.text);
                PlayerPrefs.SetString("passwd", passwd.text);

                InforMain.SetActive(true);
                dangnhap.SetActive(false);

                // Hiển thị panel nhập tên và lưu điểm
                //saveScorePanel.SetActive(true);
            }
        }
    }
}
