using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private UIManager scoreUi;

    public GameOverScreen gameOver;

    [SerializeField]
    private int score = 0;

    private void Start()
    {

        controller = GetComponent<CharacterController>();
        //transform.position = new Vector3(0,0,-5.15f);
        scoreUi = GameObject.Find("Canvas").GetComponent<UIManager>();
        gameOver = GameObject.Find("GameOver").GetComponent<GameOverScreen>();
    }


    void Update()
    { 
        
        Movement();
 
    }
    public void Movement(){
        
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //transform.rotation = new Quaternion ( transform.rotation.x, 0 , transform.rotation.z, transform.rotation.w);
        controller.Move(move * Time.deltaTime * playerSpeed);
        transform.forward = move;
              /*
         if(transform.position.x > 10)
        {
            transform.position = new Vector3(-9,0,0.49f);
        }
        if(transform.position.x > -10) 
        {
            transform.position = new Vector3(9,0,0.49f);
        }  
       */
    }

    public void addScore(int points){
       score+=points;
       scoreUi.updateScore(score);
      // UIManager.instance.updateScore(score);

    }
    private void OnTriggerEnter(Collider other){
       // if(other.gameObject.tag == "Player")
         if(other.gameObject.tag == "Enemy")
        {
            gameOver.Setup();
            Destroy(this.gameObject);   
        }
        if(other.name == "redirect1"){
            transform.position = new Vector3(-9,0,0.58f);
            //9 0,08 0.58
        }
        if(other.name == "redirect2"){
            transform.position = new Vector3(9,0,0.58f);
            
        }
    }
}
