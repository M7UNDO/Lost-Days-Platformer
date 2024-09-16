using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    private bool toggle;
    public GameObject controlPanel;
    void Start()
    {
        
    }

    public void PopUpPanel()
    {
        toggle = !toggle;
        if (toggle == false)
        {
            controlPanel.SetActive(false);
            Time.timeScale = 1.0f;
            
        }

        if (toggle)
        {
            Time.timeScale = 0;
            controlPanel.SetActive(true);
        }
        
    }
}
