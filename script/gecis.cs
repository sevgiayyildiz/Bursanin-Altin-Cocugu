using UnityEngine;
using UnityEngine.SceneManagement;

public class gecis : MonoBehaviour
{
    public GameObject sonrakiSeviyeButonu; // Sonraki seviyeye geçme butonu


   
    public void CikisButonu()
    {
        print("Oyundan Çýkýldý.");
        Application.Quit();
    }

    // Ýlk sahne
    public void Giris()
    {
        SceneManager.LoadScene("giris");
    }

    // Ýkinci sahne
    public void Tophane()
    {
        Debug.Log("tophane fonk cagýrýldý");
        SceneManager.LoadScene("tophane");
    }

    // Üçüncü sahne
    public void Golyazi()
    {
        SceneManager.LoadScene("golyazi");
    }

    // Sonraki seviyeye geçme butonunu etkinleþtir
    public void SonrakiSeviyeButonuEtkinlestir()
    {
        sonrakiSeviyeButonu.SetActive(true);
    }
   
}
