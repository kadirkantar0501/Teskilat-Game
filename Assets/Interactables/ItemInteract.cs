using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ItemInteract : Interactable
{
    [SerializeField]
    Collider col;


    protected override void Interact()
    {
        FindObjectOfType<Player>().OnCollected(col);
    }
}
