using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAndMovement : MonoBehaviour
{
    public Transform player;
    public GameObject mainCamera;

    public float playerMovementSpeed;
    public float rotateSpeed;


    // Update is called once per frame
    void Update()
    {
        // Move Forward
        if (Input.GetKey(KeyCode.W))
        {
            player.position += player.forward * playerMovementSpeed * Time.deltaTime;
        }

        // Move Right
        if (Input.GetKey(KeyCode.D))
        {
            player.position += player.right * playerMovementSpeed * Time.deltaTime;
        }

        // Move Back
        if (Input.GetKey(KeyCode.S))
        {
            player.position -= player.forward * playerMovementSpeed * Time.deltaTime;
        }

        // Move Left
        if (Input.GetKey(KeyCode.A))
        {
            player.position -= player.right * playerMovementSpeed * Time.deltaTime;
        }


        if (Input.GetAxis("Mouse X") != 0f || Input.GetAxis("Mouse Y") != 0f)
        {
            float xAmount = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
            float YAmount = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
            player.Rotate(0f, YAmount, 0f);
            mainCamera.transform.Rotate(-xAmount, 0f, 0f);
        }
    } 
}
