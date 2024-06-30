using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Multiplayer : MonoBehaviour
{
    public string[] playerNames;
    public TMP_InputField[] namesInput;
    public TextMeshProUGUI[] touresTexts;

    private void Update()
    {
        playerNames[0] = namesInput[0].text;
        playerNames[1] = namesInput[1].text;
        touresTexts[0].text = namesInput[0].text + " Mieszaj!";
        touresTexts[1].text = namesInput[1].text + " Mieszaj!";
    }
}
