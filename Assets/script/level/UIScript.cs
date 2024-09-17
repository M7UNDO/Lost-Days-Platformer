using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    [SerializeField] private LevelManager _lvlMngr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void RestartGame()
    {
        _lvlMngr.ReloadScene(_lvlMngr.currentScene);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
