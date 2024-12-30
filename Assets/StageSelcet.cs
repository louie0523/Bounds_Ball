using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelcet : MonoBehaviour
{
    public GameObject[] StageNumber;

    void Start()
    {
        for(int i = 0; DataManager.Instance.currentStage[i]; i++)
        {
            StageNumber[i].SetActive(true);
        }
    }
}
