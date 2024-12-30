using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private static DataManager instance;
    public int cureentSn = 1;
    public bool[] currentStage = new bool[9];
    public bool first = false;

    private void Start()
    {
        for (int i = 0; i < currentStage.Length; i++)
        {
            if(i == 0)
            {
                currentStage[i] = true;
            } else
            {
                currentStage[i] = false;
            }
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    public static DataManager Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }
            return instance;
        }
    }
}
