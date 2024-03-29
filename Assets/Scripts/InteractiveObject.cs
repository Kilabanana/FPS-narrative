﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour, IInteractive
{
    [SerializeField]
    private string displayText;

    public string DisplayText => displayText;

    public void InteractWith()
    {
        Debug.Log($"Player interacted with {gameObject.name}.");
    }
}
