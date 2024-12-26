using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject Pause_UI;
    public GameObject Clear_UI;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && Pause_UI.activeSelf){
            Time.timeScale = 1.0f;
            Pause_UI.SetActive(false);
        }
    }

    public void Pause_On()
    {
        if(!Clear_UI.activeSelf)
        {
            Pause_UI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
