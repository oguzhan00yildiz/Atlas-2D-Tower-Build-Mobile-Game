using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript2 : MonoBehaviour
{
    public static ScoreScript2 instance;

public int score, highScore, gameoverScore;


public Text scoreText, highScoreText, gameoverScoreText;


    private void Awake() 
    {

instance = this;
if(PlayerPrefs.HasKey("HighScore")) 
{

highScore = PlayerPrefs.GetInt("HighScore");
highScoreText.text = highScore.ToString();




}

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void AddScore() {  //skorun üstüne skor ekleyen kod yani skor her kutuda artacak

    score++;

    UpdateHighScore();
    gameoverScore=score;
    scoreText.text = score.ToString();
    gameoverScoreText.text = gameoverScore.ToString();

}

public void UpdateHighScore()  //en yüksek skoru ayarlar
{

if(score > highScore)
{
highScore=0;
highScore=score;

highScoreText.text= highScore.ToString();

PlayerPrefs.SetInt("HighScore", highScore);


}

}


public void ResetScore(){   //skoru sıfırlama kodu

    score=0;
    scoreText.text = score.ToString();
    gameoverScoreText.text = score.ToString();
}


}
