using UnityEngine;
using UnityEngine.UI;

public class hikaye : MonoBehaviour
{
    public GameObject sevgiPanel; // "sevgi" panelinin referansý

    public void GoToSevgiPanel()
    {
        // "hikaye" butonuna týklandýðýnda "sevgi" panelini aktif hale getir
        sevgiPanel.SetActive(true);
    }
}