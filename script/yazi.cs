using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class yazi : MonoBehaviour
{
    public Text textField;
    public string fullText = "Bursa'n�n Alt�n �ocu�u: Macera Yolculu�u\n\nBursa'n�n tarih kokan sokaklar�nda, k���k bir �ocuk b�y�l� bir maceraya ad�m at�yor. Ad� Ali. Bir g�n, Tophane'deki eski bir kona��n bah�esinde dola��rken eski sand�klar aras�nda parlayan alt�nlar� fark eder. Heyecanla ba��r�r, 'Alt�nlar burada! Buras� bir define!'\n\nSand�klar� kar��t�r�rken, bir par�lt�yla g�zleri kama��r. Aniden kendini G�lyaz�'da bulur. Ye�ilin ve mavinin b�y�leyici uyumunu sunan bu cennet, onu alt�nlar� toplamak i�in yeni bir maceraya s�r�kler.\n\nG�lyaz�'n�n ta�l� yollar�nda ko�u�tururken, her alt�n� toplad�k�a �evresindeki manzara daha da g�zelle�ir. Son alt�n� ald���nda etraf� bir ���kla dolar. Bu deneyim, Ali'nin unutamayaca�� bir maceran�n sonudur. Art�k Bursa'n�n alt�n �ocu�u olarak bilinecektir.";
    private string currentText = "";
    public float delay = 0.1f;

    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            textField.text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}