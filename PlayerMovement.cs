using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     private CharacterController controller;
    public float speed = 5.0f;
    private float verticalVelocity = 0.0f;
    public float gravity = 12.0f;
    private Vector3 moveVector;
    public float jumpSpeed = 20f;
    public float maxspeed = 30f;
    public int count;
    public AudioSource audioSource;
    
    // Start is called before the first frame update
    

    void Start()
    {
        StartCoroutine(timer(5));
        StartCoroutine(timer1(5));
        controller = GetComponent<CharacterController>();
    
    }
    // Update is called once per frame
    void Update()
    {
       
    verticalVelocity = -gravity * Time.deltaTime;
    if(controller. isGrounded && Input. GetButtonDown("Jump"))
        {
            moveVector.y = jumpSpeed;      
        }else{
              moveVector.y -= gravity * Time.deltaTime;
             }
             moveVector.x = Input.GetAxisRaw("Horizontal") * 10f;

       if(count == 0)
       {
         moveVector.z = speed;      
       }
      controller.Move (moveVector * Time.deltaTime);
    }

    IEnumerator timer1(int seconds)
        {
         count = seconds;
       
        while (count > 0) 
        {   
            yield return new WaitForSeconds(1);
            count --;
             }
        }


    IEnumerator timer(int seconds = 5)
        {  
            yield return new WaitForSeconds(seconds);
            GetComponent<AudioSource>().Play();
        }
    
}

