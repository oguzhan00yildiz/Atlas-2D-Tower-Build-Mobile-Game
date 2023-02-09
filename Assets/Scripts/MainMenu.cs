using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public void PlayGame ()
    {
        SceneManager.LoadScene("SampleScene");  // play tuşuna basınca oyunu başlatır


    }


    public void QuitGame()    //quit tuşuna basınca oyunu kapatır

    {

        Debug.Log("Quit!");
        Application.Quit();


    }

}



