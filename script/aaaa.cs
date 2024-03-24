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
        kazandinPanel.SetActive(false); // Ba�lang��ta kazanma panelini gizle
        kaybettinizPanel.SetActive(false); // Ba�lang��ta kaybetme panelini gizle
    }

    void Update()
    {
        text.text = coinAmount.ToString();

        // E�er oyuncu 100 puana ula�t�ysa ve "tophane" sahnesinde ise veya oyuncu zaman dolduysa
        if ((coinAmount >= 100 && SceneManager.GetActiveScene().name == "tophane") || ZamanDoldu())
        {
            OyunuBitir();
        }
        // E�er oyuncu 100 puana ula�t�ysa ve "golyazi" sahnesinde ise veya oyuncu zaman dolduysa
        else if ((coinAmount >= 100 && SceneManager.GetActiveScene().name == "golyazi") || ZamanDoldu())
        {
            OyunuBitir();
        }

        // Karakterin hareket etmesi i�in zaman kontrol� ekleyelim
        if (SceneManager.GetActiveScene().name == "golyazi" && !ZamanDoldu())
        {
            // Karakterin normal hareket kodu buraya gelecek
        }
    }

    // Zaman dolmu� mu kontrol�
    bool ZamanDoldu()
    {
        // Burada zaman dolma ko�ulunu kontrol et
        // �rne�in: return zaman <= 0;
        return false; // �imdilik her zaman false d�nd�rd�m, zaman kontrol�n� nas�l yapaca��n�za ba�l� olarak bu k�sm� g�ncelleyebilirsiniz.
    }

    // Oyunu bitirme i�lemi
    void OyunuBitir()
    {
        // E�er oyuncu yeterli puana ula�t�ysa kazanma panelini g�ster
        if (coinAmount >= 100 || coinAmount >= 100)
        {
            kazandinPanel.SetActive(true);
        }
        // E�er oyuncu yeterli puana ula�amad�ysa veya zaman dolduysa kaybetme panelini g�ster
        else
        {
            kaybettinizPanel.SetActive(true);
        }
    }

    // Oyuncu yeniden ba�lat butonuna basarsa
    public void YenidenBaslat()
    {
        // Puan� s�f�rla
        coinAmount = 0;

        // Oyunu yeniden ba�lat
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}