using UnityEngine;
using UnityEngine.UI;

public class hikaye : MonoBehaviour
{
    public GameObject sevgiPanel; // "sevgi" panelinin referansı

    public void GoToSevgiPanel()
    {
        // "hikaye" butonuna tıklandığında "sevgi" panelini aktif hale getir
        sevgiPanel.SetActive(true);
    }
}