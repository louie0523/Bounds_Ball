using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScencBtn : MonoBehaviour
{
    public int senceName;
    public GameObject SNT;
    public void bnLoadSecne()
    {
        if (SNT.activeSelf)
        {
            SceneManager.LoadScene(1+senceName);
            DataManager.Instance.cureentSn = senceName;
        } else
        {
            Debug.Log("이전 스테이지를 클리어 하고 오세요~");
        }
    }
}
