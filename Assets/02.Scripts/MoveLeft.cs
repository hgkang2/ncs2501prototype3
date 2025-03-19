using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float leftBound = -15.0f;
    private float speed = 30.0f;
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(transform.position.x < leftBound && gameObject.CompareTag("OBSTACLE"))
        {
            Destroy(gameObject);
        }
    }
}