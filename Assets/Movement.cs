using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 20f;
    public CharacterController controller;
    Vector3 velocity;
    float gravity = -9.81f;
    bool isgrounded;
   public Transform groundcheck;
    public float GroundDistance = 0.4f;
    public LayerMask groundmask;
    public float jumpheight=3f;
   

    // Update is called once per frame
    void Update()
    {

        isgrounded = Physics.CheckSphere(groundcheck.position, GroundDistance, groundmask);


        if(isgrounded && velocity.y <0)
        {
            velocity.y = -2f;
        }

        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        // Vector3 move = transform.right * X + transform.forward * Z; //(forward for Z)
        //right for X
        Vector3 move = transform.right * X + transform.forward * Z;
        controller.Move(move * Time.deltaTime * speed);

       if(Input.GetKey(KeyCode.Space) && isgrounded)
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime; //why did i forget to add Time.deltatime??
        controller.Move(velocity * Time.deltaTime);
    }
}
