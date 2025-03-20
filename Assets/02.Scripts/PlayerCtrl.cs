using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float speed;
    private Rigidbody playerRb;
    private float verticlaInput;
    private float horizontalInput;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector3.left*10f,ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerRb.AddForce(Vector3.right*10f,ForceMode.Impulse);
        }
    }
}
