using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Load : MonoBehaviour
{
    public GameObject LastStage;
    public TextMeshProUGUI LastStageText;
    private void Start()
    {
        if(DataManager.Instance.first)
        {
            LastStage.SetActive(true);
            LastStageText.text = "Last Stage : " + DataManager.Instance.cureentSn.ToString();
        }
    }
    
    public void inagme()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StageSelcet()
    {
        SceneManager.LoadScene(DataManager.Instance.cureentSn+1);
    }
}
