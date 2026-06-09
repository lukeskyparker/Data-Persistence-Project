using UnityEngine;
using TMPro;

public class SceneTwoController : MonoBehaviour
{
    [SerializeField] private TMP_Text displayField;

    private void Start()
    {
        // Check if the instance exists and populate the text field
        if (DataManager.Instance != null && displayField != null)
        {
            displayField.text = "Best Score: " + DataManager.Instance.SharedText + ": 0000";
        }
    }
}
