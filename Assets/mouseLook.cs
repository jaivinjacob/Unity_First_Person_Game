using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mouseLook : MonoBehaviour
{
    public FixedTouchField TouchField;
    public Vector2 lookAxis;
    
    public float mouseSensitivity = 100f;
    //public Joystick joystick;
    public Transform playerBody;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        lookAxis = TouchField.TouchDist;
     
       // float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //float mouseX = joystick.Horizontal * mouseSensitivity * Time.deltaTime;
       //float mouseY = joystick.Vertical * mouseSensitivity * Time.deltaTime;
       float mouseX = lookAxis.x * mouseSensitivity * Time.deltaTime;
        float mouseY = lookAxis.y * mouseSensitivity * Time.deltaTime;

        

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
