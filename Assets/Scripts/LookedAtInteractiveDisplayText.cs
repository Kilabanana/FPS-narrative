using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This UI text display's info on currently looked at interactive IInterractive.
/// The text should be hidden if player isn't looking at interactive element.
/// </summary>
public class LookedAtInteractiveDisplayText : MonoBehaviour
{
    private IInteractive lookedAtInteractive;
    private Text displayText;

    private void Awake()
    {
        displayText = GetComponent<Text>();   
    }

    private void UpdateDisplayText()
    {
        if (lookedAtInteractive != null)
            displayText.text = lookedAtInteractive.DisplayText;
        else
            displayText.text = string.Empty;
    }

    private void OnLookedAtInteractiveChanged()
    {
        UpdateDisplayText();
    }
}
