using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.SceneManagement;



// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

   
}
