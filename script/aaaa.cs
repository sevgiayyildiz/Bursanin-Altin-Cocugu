using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class aaaa : MonoBehaviour
{
    Text text;
    public static int coinAmount;
    public GameObject kazandinPanel;
    public GameObject kaybettinizPanel;

    void Start()
    {
        text = GetComponent<Text>();
        coinAmount = 0;
        kazandinPanel.SetActive(false); // Baþlangýçta kazanma panelini gizle
        kaybettinizPanel.SetActive(false); // Baþlangýçta kaybetme panelini gizle
    }

    void Update()
    {
        text.text = coinAmount.ToString();

        // Eðer oyuncu 100 puana ulaþtýysa ve "tophane" sahnesinde ise veya oyuncu zaman dolduysa
        if ((coinAmount >= 100 && SceneManager.GetActiveScene().name == "tophane") || ZamanDoldu())
        {
            OyunuBitir();
        }
        // Eðer oyuncu 100 puana ulaþtýysa ve "golyazi" sahnesinde ise veya oyuncu zaman dolduysa
        else if ((coinAmount >= 100 && SceneManager.GetActiveScene().name == "golyazi") || ZamanDoldu())
        {
            OyunuBitir();
        }

        // Karakterin hareket etmesi için zaman kontrolü ekleyelim
        if (SceneManager.GetActiveScene().name == "golyazi" && !ZamanDoldu())
        {
            // Karakterin normal hareket kodu buraya gelecek
        }
    }

    // Zaman dolmuþ mu kontrolü
    bool ZamanDoldu()
    {
        // Burada zaman dolma koþulunu kontrol et
        // Örneðin: return zaman <= 0;
        return false; // Þimdilik her zaman false döndürdüm, zaman kontrolünü nasýl yapacaðýnýza baðlý olarak bu kýsmý güncelleyebilirsiniz.
    }

    // Oyunu bitirme iþlemi
    void OyunuBitir()
    {
        // Eðer oyuncu yeterli puana ulaþtýysa kazanma panelini göster
        if (coinAmount >= 100 || coinAmount >= 100)
        {
            kazandinPanel.SetActive(true);
        }
        // Eðer oyuncu yeterli puana ulaþamadýysa veya zaman dolduysa kaybetme panelini göster
        else
        {
            kaybettinizPanel.SetActive(true);
        }
    }

    // Oyuncu yeniden baþlat butonuna basarsa
    public void YenidenBaslat()
    {
        // Puaný sýfýrla
        coinAmount = 0;

        // Oyunu yeniden baþlat
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}