using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame1()
    {
        Application.LoadLevel("Level1");
    }

    public void PlayGame2()
    {
        Application.LoadLevel("Level2");
    }

    public void QuitGame() 
    {
        Debug.Log("Keluar game!!!");
        Application.Quit();
    }


}
