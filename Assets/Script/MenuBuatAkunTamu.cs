using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement; //namespace ini kita butuhkan agar dapat memanggil fungsi yang ada pada class SceneManagement
// using UnityEngine

public class MenuBuatAkunTamu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Kondisi ketika ada Input dari keyboard 
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();     //Fungsi untuk keluar dari game / aplikasi
            Debug.Log("Quit Game"); //Mencetak output string pada Console
        }
    }

    //Membuat fungsi agar dapat berpindah kembali ke scene PilihMasukDengan
    public void BackToPilihMasukDengan()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("PilihMasukDenganScene");
    }
    public void ForwardToMenuUtama()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("MenuUtamaScene");
    }
    // public GameObject Panel;
    // public class GetComponentsInChildrenExample : MonoBehaviour
    // {
    //     public Component[] hingeJoint;

    //     void Start()
    //     {
    //         hingeJoint = GetComponentsInChildren<HingeJoint>();
    //     }
    // }

    public void PilihAvatar()
    {
        // GameObject.Find("PanelAvatar1").GetComponentsInParent<T>();f
    }
}
