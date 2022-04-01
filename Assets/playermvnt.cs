using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermvnt : MonoBehaviour
{

    public CharacterController playerCol;
    float originalHeight;
    public float reducedHeight;
    //
    public Joystick joystick;
    
    [SerializeField]private crouchButtonScript crouchButton;

    public CharacterController controller;
    public float speed = 5f;
    public float gravity = -9.8f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
   // public float jumpHeight = 1f;

    
   
    Vector3 velocity;
    bool isGrounded;

    private Animator anim;
    void Awake(){
        anim = GetComponent<Animator>();
    }

    void Start()
    {

        playerCol = GetComponent<CharacterController>();
        originalHeight = playerCol.height;
    }
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y<0)
        {

            velocity.y =-2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //float x = joystick.Horizontal;
        //float z = joystick.Vertical;

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(move.magnitude>0.1f){
            anim.SetBool("run",true);
        }
        else {
            anim.SetBool("run",false);
        }
       /* if((Input.GetButtonDown("Jump") && isGrounded) || (joybutton.isPressing && isGrounded))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        }
*/
        velocity.y +=gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //crouch addons
        if(Input.GetKeyDown(KeyCode.LeftControl) || (crouchButton.isPressing))
        {
            Crouch();
        }
        
        else if(Input.GetKeyUp(KeyCode.LeftControl) && !(crouchButton.isPressing) )
        {
            GoUp();
        }
       
    }
    //crouch method
    void Crouch()
    {

        playerCol.height = reducedHeight;
    }
    void GoUp()
    {

        playerCol.height = originalHeight;
    }

}
