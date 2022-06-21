using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float MouseInsensitivity = 200f;
    public Transform playerBody;
    float yRotation = 0;
    void Start()
    {
       //I WAS TRYING TO CACHE THE TRANSFORM OF THE FUCKING CAMERA!!!
      Cursor.lockState = CursorLockMode.Locked; //this locks the cursor ->cursor.locksate=cursorlockmade.locked!
    }

   
    void Update()
    {
            float mouseX = Input.GetAxis("Mouse X") * MouseInsensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * MouseInsensitivity * Time.deltaTime;

           yRotation -= mouseY; //why y rotation is -mousey? (inverted,thats why)
                                //here we ant to rotate the camera
                                //keep subtrating the mousey From the rotatation!!
           yRotation= Mathf.Clamp(yRotation, -90f ,90f);
           transform.localRotation = Quaternion.Euler(yRotation, 0,0);       
           playerBody.Rotate(Vector3.up * mouseX); 
        // it has to be mouse x * Vector3.up because you want to rotate it on X axis against Y

            
    }
}
