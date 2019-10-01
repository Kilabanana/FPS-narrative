using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Detects when player presses INTERACT while looking at IInteractive,
/// then calls IInteractive's InteractWith method.
/// </summary>
public class InteractWithLookedAt : MonoBehaviour
{
    [SerializeField]
    private DetectLookedAtInteractive detectLookedAtInteractive;

     //Update is called once per frame
     void Update()
    {
        if (Input.GetButtonDown("Interact") && detectLookedAtInteractive.LookedAtInteractive != null)
        {
            Debug.Log("Player pressed the Interact button.");
            detectLookedAtInteractive.LookedAtInteractive.InteractWith();
        }
    }
}
