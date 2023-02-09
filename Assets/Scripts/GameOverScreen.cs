using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");  //oyun restarlayınca sahneyi sıfırlayan kod

        ScoreScript.scoreValue = 0;

    }

    public void ExitButton()
    {

        SceneManager.LoadScene("MainMenu");  //ana menüye çıkaran kod
    }



}

