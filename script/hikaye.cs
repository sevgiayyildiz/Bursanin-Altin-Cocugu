using UnityEngine;
using UnityEngine.UI;

public class hikaye : MonoBehaviour
{
    public GameObject sevgiPanel; // "sevgi" panelinin referans�

    public void GoToSevgiPanel()
    {
        // "hikaye" butonuna t�kland���nda "sevgi" panelini aktif hale getir
        sevgiPanel.SetActive(true);
    }
}