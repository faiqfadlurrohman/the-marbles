using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuUtama : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();     //Fungsi untuk keluar dari game / aplikasi
            Debug.Log("Quit Game"); //Mencetak output string pada Console
        }
    }
    public void ForwardToPilihMode()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("PilihModeScene");
    }
     public void ForwardToPengaturan()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("PengaturanScene");
    }

    public void ExitGame()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        Application.Quit();
    }
}
