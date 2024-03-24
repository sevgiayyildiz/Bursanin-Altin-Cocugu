using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]

public class PLAYERcontrol : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;


    public float moveSpeed;
    public CharacterController characterController;
    public Transform cam;
    public float lookSensitivity;
    public float maxXRot = 90f;
    public float minXRot = -90f;
    private float curXRot = 0f;
    bool oyunDevam = true;

    void Start()

    {
        rb = GetComponent<Rigidbody>();


        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Move();
        Look();
    }

    void Move()
    {
       if (oyunDevam)
        {
            float x = Input.GetAxis("Horizontal"); // Yatay hareket
            float z = Input.GetAxis("Vertical"); // Dikey hareket

            Vector3 move = transform.right * x + transform.forward * z; // Hareket vekt�r� olu�tur
            characterController.Move(move * moveSpeed * Time.deltaTime); // Hareketi uygula
        }
    }

    void Look()
    {
        float mouseX = Input.GetAxis("Mouse X") * lookSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * lookSensitivity;

        // Yatay d�n�� (karakterin etraf�nda)
        transform.eulerAngles += Vector3.up * mouseX;

        // Dikey d�n�� (kameran�n etraf�nda)
        curXRot -= mouseY;
        curXRot = Mathf.Clamp(curXRot, minXRot, maxXRot);
        cam.localRotation = Quaternion.Euler(curXRot, 0f, 0f);
    }
}