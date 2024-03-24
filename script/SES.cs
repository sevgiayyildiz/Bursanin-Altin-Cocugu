using UnityEngine;
using UnityEngine.UI;

public class SES : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;

    void Start()
    {
        // Ba�lang��ta slider'�n de�erini varsay�lan ses seviyesine ayarla
        volumeSlider.value = PlayerPrefs.GetFloat("VolumeLevel", 0.5f);
        audioSource.volume = volumeSlider.value;
        // Slider'�n de�i�ikliklerini dinle
        volumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(); });
    }

    void ChangeVolume()
    {
        // Ses seviyesini slider'�n de�erine g�re de�i�tir
        audioSource.volume = volumeSlider.value;
        // Ses seviyesini kaydet
        PlayerPrefs.SetFloat("VolumeLevel", volumeSlider.value);
    }
}