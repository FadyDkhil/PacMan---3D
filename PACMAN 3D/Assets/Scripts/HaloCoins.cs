using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaloCoins : MonoBehaviour
{
[SerializeField]
    private PlayerMovement player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Chomp").GetComponent<PlayerMovement>();
    }

    
    // Update is called once per frame
    void Update()
    {
        
       
    }
    private void OnTriggerEnter(Collider other){
       // if(other.gameObject.tag == "Player")
         if(other.name == "Chomp")
        {
            if(player != null){
                player.addScore(200);
            }
            
            Destroy(this.gameObject);
        }

        Debug.Log("score");
    }
    //private void OnTriggerEnter
}
