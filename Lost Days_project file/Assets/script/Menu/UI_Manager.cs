using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [Header("Canvas")]
    public GameObject CanvasGame;
    public GameObject CanvasRestart;

private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        CanvasRestart.SetActive(true);
    }

    public void ShowRestartCanvas()
    {
        CanvasGame.SetActive(false);
        CanvasRestart.SetActive(true);
    }
    



    public void ShowMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
