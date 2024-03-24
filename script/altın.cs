using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altın : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "karakter")
        {
            aaaa.coinAmount += 10;
            Destroy(gameObject);
        }
    }
}