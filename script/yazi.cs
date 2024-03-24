using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class yazi : MonoBehaviour
{
    public Text textField;
    public string fullText = "Bursa'nýn Altýn Çocuðu: Macera Yolculuðu\n\nBursa'nýn tarih kokan sokaklarýnda, küçük bir çocuk büyülü bir maceraya adým atýyor. Adý Ali. Bir gün, Tophane'deki eski bir konaðýn bahçesinde dolaþýrken eski sandýklar arasýnda parlayan altýnlarý fark eder. Heyecanla baðýrýr, 'Altýnlar burada! Burasý bir define!'\n\nSandýklarý karýþtýrýrken, bir parýltýyla gözleri kamaþýr. Aniden kendini Gölyazý'da bulur. Yeþilin ve mavinin büyüleyici uyumunu sunan bu cennet, onu altýnlarý toplamak için yeni bir maceraya sürükler.\n\nGölyazý'nýn taþlý yollarýnda koþuþtururken, her altýný topladýkça çevresindeki manzara daha da güzelleþir. Son altýný aldýðýnda etrafý bir ýþýkla dolar. Bu deneyim, Ali'nin unutamayacaðý bir maceranýn sonudur. Artýk Bursa'nýn altýn çocuðu olarak bilinecektir.";
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