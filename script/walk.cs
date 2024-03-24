using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    
    private Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        DontDestroyOnLoad(gameObject); // walk nesnesini sahne de�i�ikli�inde koru
    }

    void Update()
    {
        // Y�n tu�lar�yla hareket etme
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        transform.Translate(movement * Time.deltaTime);

       
        // Ko�ma animasyonunu oynatma
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isrun", true);
            transform.Translate(new Vector3(0, 0, 20f)*Time.deltaTime);

        }
        else
        {
            animator.SetBool("isrun", false);
        }

       
    }
    
}