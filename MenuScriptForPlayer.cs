using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScriptForPlayer : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 5.0f;
    public float gravity = 12.0f;
    private bool turn;
    private Vector3 moveVector;
    public GameObject player;
    public float thresholdHeight = -10f;
    public Transform spawnPoint;
    public float jumpSpeed = 10f;
    private float stationary = 0;
    public Text TextDisplay;
    GameObject TextImage;
    
    // Start is called before the first frame update
    void Start()
    {
         controller = GetComponent<CharacterController>();
         TextImage = GameObject.Find("TextImage");
         TextImage.active = false;
         turn = false;
    }

    // Update is called once per frame
    void Update()
    { 
        if(controller. isGrounded)
        {
            moveVector.x = speed;
        }

         controller.Move (moveVector * Time.deltaTime);

         moveVector.y -= gravity * Time.deltaTime;      
    }
      
      
      public void OnTriggerEnter(Collider other)
    {

        if(other.tag == "S")
        {
             player.transform.position = spawnPoint.position;
             print("yess!");
        } 
        if(other.tag == "J")    
        {
            moveVector.y = jumpSpeed;
            print("Yes!");
        }  
        if(other.tag == "TextDisplay")    
        {
            StartCoroutine(RotationPlayer()); 
        }  
    }  

     IEnumerator RotationPlayer(float waitTime = 0.02f)
        {        
            if(turn = true)
            {
            yield return new WaitForSeconds(waitTime);
            TextImage.active = true;
            TextDisplay.text = "Let's go" + "\n" + "Choose you level!";
            yield return new WaitForSeconds(waitTime);
            Vector3 rotation = new Vector3(0, 45f, 0);
            transform.Rotate(rotation);     
            StartCoroutine(RotationPlayer1());
            }       
        }
        IEnumerator RotationPlayer1(float waitTime = 0.02f)
        {     
            yield return new WaitForSeconds(waitTime);
            Vector3 rotation = new Vector3(0, 45f, 0);
            transform.Rotate(rotation); 
            yield return new WaitForSeconds(waitTime);
             StartCoroutine(RotationPlayer2());       
        }
        IEnumerator RotationPlayer2(float waitTime = 0.02f)
        {
             yield return new WaitForSeconds(waitTime);
            Vector3 rotation = new Vector3(0, 45f, 0);
            transform.Rotate(rotation); 
            yield return new WaitForSeconds(waitTime);
             StartCoroutine(RotationPlayer3());
        }
        IEnumerator RotationPlayer3(float waitTime = 0.02f)
        {
             yield return new WaitForSeconds(waitTime);
            Vector3 rotation = new Vector3(0, 45f, 0);
            transform.Rotate(rotation); 
            yield return new WaitForSeconds(waitTime);
             StartCoroutine(RotationPlayer4());
        }
        IEnumerator RotationPlayer4(float waitTime = 0.02f)
        {
            yield return new WaitForSeconds(waitTime);
            Vector3 rotation = new Vector3(0, 90f, 0);
            transform.Rotate(rotation); 
            yield return new WaitForSeconds(waitTime);
            turn = false; 
        }

    

}
