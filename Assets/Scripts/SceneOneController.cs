using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneOneController : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;

    public void SaveAndNextScene()
    {
        if (inputField != null && DataManager.Instance != null)
        {
            // Save the UI text field value into our global instance
            DataManager.Instance.SharedText = inputField.text;
            
            // Load the next scene (replace with your actual scene name)
            SceneManager.LoadScene(1);
        }
    }
}