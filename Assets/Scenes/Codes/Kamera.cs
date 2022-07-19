using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public float sensitivity = 1f;
    private Vector3 rotate;
    float x;

    void Start()
    {
        
    }

    void Update()
    {
        x = Input.GetAxis("Mouse Y");
        rotate = new Vector3 (x * sensitivity, 0);
        transform.eulerAngles = transform.eulerAngles - rotate;
    }
}