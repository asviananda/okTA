using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 40;
    public Rigidbody rb;
    public float horizontalSpeed = 1.0f;
    float v;

    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        //movement maju
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }

        //movement mundur
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }

        //movement kanan
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime * movementSpeed;
        }

        //movement kiri
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed;
        }

        //movement 360 view
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(v, h, 0);

    }

}