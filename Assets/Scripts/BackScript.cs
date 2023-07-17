using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour
{
    public void BackToMenu ()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

}
