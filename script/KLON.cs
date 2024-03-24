using UnityEngine;

public class KlonlananNesneYonetici : MonoBehaviour
{
    static KlonlananNesneYonetici instance;

    void Awake()
    {
        // Y�netici nesne olu�turuldu�unda di�er klonlanm�� nesnelerin yok olmas�n� sa�la
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        // Y�netici nesneyi yok etme, b�ylece sahnede kal�r
        DontDestroyOnLoad(gameObject);
    }

    // Klonlanan nesnelerin temizlenmesi i�in bir fonksiyon
    public void KlonlananNesneleriTemizle()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}