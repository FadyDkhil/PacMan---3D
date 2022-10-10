using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOverScreen : MonoBehaviour
{

 

    
  public void tryAgain(){
      SceneManager.LoadScene("Game");
  }
  public void Setup(){
      gameObject.SetActive(true);
      //scoreText.text = "Score: " + score.ToString();
      
  }
}
