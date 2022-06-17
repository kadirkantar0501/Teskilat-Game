using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordButton : Interactable
{
    [SerializeField]
    private GameObject sword;
    [SerializeField]
    private GameObject _light;

    private bool isPlaying;

    protected override void Interact()
    {
        isPlaying = !isPlaying;
        sword.GetComponent<Animator>().SetBool("IsPlaying",isPlaying);   
        _light.SetActive(isPlaying);
    }
}
