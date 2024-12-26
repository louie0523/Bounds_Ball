using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject Clear_UI;
    public GameObject Pause;
    private void Start()
    {
        Clear_UI.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player") && !Pause.activeSelf)
        {
            Clear_UI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    

    public void GoHome()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
