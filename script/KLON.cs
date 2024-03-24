using UnityEngine;

public class KlonlananNesneYonetici : MonoBehaviour
{
    static KlonlananNesneYonetici instance;

    void Awake()
    {
        // Yönetici nesne oluþturulduðunda diðer klonlanmýþ nesnelerin yok olmasýný saðla
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        // Yönetici nesneyi yok etme, böylece sahnede kalýr
        DontDestroyOnLoad(gameObject);
    }

    // Klonlanan nesnelerin temizlenmesi için bir fonksiyon
    public void KlonlananNesneleriTemizle()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}