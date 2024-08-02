using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    public static MenuManagerScript instance;
    public void PlayGame()
    {
        SceneManager.LoadScene("MEET YOUR MAKER LEVEL SCENE");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}