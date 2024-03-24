using UnityEngine;
using UnityEngine.SceneManagement;

public class gecis : MonoBehaviour
{
    public GameObject sonrakiSeviyeButonu; // Sonraki seviyeye ge�me butonu


   
    public void CikisButonu()
    {
        print("Oyundan ��k�ld�.");
        Application.Quit();
    }

    // �lk sahne
    public void Giris()
    {
        SceneManager.LoadScene("giris");
    }

    // �kinci sahne
    public void Tophane()
    {
        Debug.Log("tophane fonk cag�r�ld�");
        SceneManager.LoadScene("tophane");
    }

    // ���nc� sahne
    public void Golyazi()
    {
        SceneManager.LoadScene("golyazi");
    }

    // Sonraki seviyeye ge�me butonunu etkinle�tir
    public void SonrakiSeviyeButonuEtkinlestir()
    {
        sonrakiSeviyeButonu.SetActive(true);
    }
   
}
