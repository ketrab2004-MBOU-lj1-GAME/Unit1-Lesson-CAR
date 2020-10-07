﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float turnSpeed = 35f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float leftRight = Input.GetAxis("Horizontal");
        float forwardBack = Input.GetAxis("Vertical");
        //vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardBack);
        //horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * leftRight);
    }
}
