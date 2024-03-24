
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class tophane : MonoBehaviour
{


    public void YenidenBasla()
    {
        SceneManager.LoadScene("tophane");
    }

    public void CikisButonu()
    {
        print("Oyundan Çýkýldý.");
        Application.Quit();
    }
    public void giris()
    {
        SceneManager.LoadScene("giris");
    }
    public void golyazi()
    {
        SceneManager.LoadScene("golyazi");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;

        }

    }



}