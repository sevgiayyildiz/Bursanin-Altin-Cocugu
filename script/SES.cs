using UnityEngine;
using UnityEngine.UI;

public class SES : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;

    void Start()
    {
        // Baþlangýçta slider'ýn deðerini varsayýlan ses seviyesine ayarla
        volumeSlider.value = PlayerPrefs.GetFloat("VolumeLevel", 0.5f);
        audioSource.volume = volumeSlider.value;
        // Slider'ýn deðiþikliklerini dinle
        volumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(); });
    }

    void ChangeVolume()
    {
        // Ses seviyesini slider'ýn deðerine göre deðiþtir
        audioSource.volume = volumeSlider.value;
        // Ses seviyesini kaydet
        PlayerPrefs.SetFloat("VolumeLevel", volumeSlider.value);
    }
}