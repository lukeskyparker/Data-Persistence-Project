using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance {get; private set; }

    public string SharedText { get; set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
       
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
