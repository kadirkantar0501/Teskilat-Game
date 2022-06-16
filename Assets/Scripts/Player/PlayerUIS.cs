using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUIS : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI prompText;


    public void UpdateText(string promptMessage) {
        prompText.text = promptMessage;
    }
}
