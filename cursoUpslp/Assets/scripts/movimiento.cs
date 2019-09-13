using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float gSpeed = 10.0f;
    public float rSpeed = 10.0f;
    public float jmpSpeed = 1.0f;
    private float gravity = 6.0f;

    private Vector3 moveDirection = Vector3.zero;
    CharacterController controller;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //Debug.Log(moveDirection);
        if(controller.isGrounded)
        {
            //Debug.Log("en suelo " + " vector " + moveDirection);
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= gSpeed;
        }
        else
        {

        }
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

    }
    
}
