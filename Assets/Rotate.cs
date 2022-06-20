using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float MouseInsensitivity = 200f;
    public Transform playerBody;
    public float yRotation;
    void Start()
    {
        playerBody = GetComponent<Transform>();
    }

   
    void Update()
    {
            float mouseX = Input.GetAxis("Mouse X") * MouseInsensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * MouseInsensitivity * Time.deltaTime;

           yRotation = -mouseY; //why y rotation is -mousey? (inverted,thats why)
                                //here we ant to rotate the camera
         Mathf.Clamp(yRotation, -90, 90);
        transform.localRotation = transform.localEulerAngles();         
           playerBody.Rotate(Vector3.up * mouseX); 
        // it has to be mouse x * Vector3.up because you want to rotate it on X axis against Y

            
    }
}
