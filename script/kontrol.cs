using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kontrol : MonoBehaviour
{

    public GameObject kazandinPanel;
    public GameObject kaybettinizPanel;
    public Text zaman;
    public Text puanText;
    float zamanSayaci = 60;
    int puan = 0;
    bool oyunDevam = true;


    void Start()
    {
        KazandinPaneliKapat();
        KaybettinizPaneliKapat();
        ResetOyunDurumu();
        ResetPuanDurumu();

    }

    void Update()
    {
        if (zaman!=null)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = ((int)zamanSayaci).ToString();
            if (zamanSayaci <= 0)
            {
                OyunuTamamla();
            }
        }
    }


    public void OyunuTamamla()
    {
        oyunDevam = false;
        KaybettinizPaneliGoster();
        PuanToplamayiDurdur();
    }

    public void YenidenBaslat()
    {
        ResetOyunDurumu();
        zamanSayaci = 60;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void ResetOyunDurumu()
    {
        zamanSayaci = 60;
        puan = 0;
        oyunDevam = true;
        puanText.text = puan.ToString();
    }
    void ResetPuanDurumu()
    {
        puan = 0;
        UpdatePuanText();
    }

    void KazandinPaneliGoster()
    {
        kazandinPanel.SetActive(true);
    }

    void KazandinPaneliKapat()
    {
        kazandinPanel.SetActive(false);
    }

    void KaybettinizPaneliGoster()
    {
        kaybettinizPanel.SetActive(true);
    }

    void KaybettinizPaneliKapat()
    {
        kaybettinizPanel.SetActive(false);
    }

    public void PuanToplamayiDurdur()
    {
        oyunDevam = false;
    }

    public void PuanEkle(int eklenecekPuan)
    {
        puan += eklenecekPuan;
        puanText.text = puan.ToString();
    }

    public void PuanKontrol()
    {
        if (SceneManager.GetActiveScene().name == "tophane")
        {
            if (puan >= 100)
            {
                SceneManager.LoadScene("golyazi");
                ResetOyunDurumu();
                ResetPuanDurumu();
            }
            else
            {
                KaybettinizPaneliGoster();
            }
        }
        else if (SceneManager.GetActiveScene().name == "golyazi")
        {
            if (puan >= 100)
            {
                SceneManager.LoadScene("oyunBitti");
                ResetOyunDurumu();
                ResetPuanDurumu();
                zamanSayaci = 60;
            }
            else
            {
                KaybettinizPaneliGoster();
            }
        }
    }
    void UpdatePuanText()
    {
        if (puanText != null)
        {
            puanText.text = puan.ToString();
        }
    }
}