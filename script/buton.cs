using UnityEngine;
using UnityEngine.UI;

public class buton : MonoBehaviour
{
    public Button restartButton;

    void Start()
    {
        // Yeniden ba�lat butonuna t�klama olay�n� ekleme
        restartButton.onClick.AddListener(RestartGame);
    }

    // Oyunun yeniden ba�lat�laca�� fonksiyon
    void RestartGame()
    {
        // Oyunun ba�lang�� durumuna getirme i�lemleri burada yap�l�r
        Debug.Log("Oyun yeniden ba�lat�l�yor!");
    }
}
