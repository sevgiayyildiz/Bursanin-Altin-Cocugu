using UnityEngine;
using UnityEngine.UI;

public class buton : MonoBehaviour
{
    public Button restartButton;

    void Start()
    {
        // Yeniden baþlat butonuna týklama olayýný ekleme
        restartButton.onClick.AddListener(RestartGame);
    }

    // Oyunun yeniden baþlatýlacaðý fonksiyon
    void RestartGame()
    {
        // Oyunun baþlangýç durumuna getirme iþlemleri burada yapýlýr
        Debug.Log("Oyun yeniden baþlatýlýyor!");
    }
}
