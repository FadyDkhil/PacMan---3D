using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score= 0;
    int highscore= 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        score = 0;
        scoreText.text = "Score: 0";
        highscoreText.text = "High score: " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void updateScore(int playerScore){
        score++;
        scoreText.text = "Score: " + score.ToString();
        if(highscore < score){
            PlayerPrefs.SetInt("highscore", score);
        }
            
    }
}
