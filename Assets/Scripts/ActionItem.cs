using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionItem : Interactable
{
  public override void Interact()
    {
        base.Interact();
        Debug.Log("Interacting with base Action Item");
    }
}
