using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComputerInputCode : MonoBehaviour
{
    public TextMeshProUGUI Result;
    public TMP_InputField TerminalInput;
    public GameObject sigge;
    public string SentCommand;

    public void TextToCommand()
    {
        SentCommand = TerminalInput.text;

        if(SentCommand == "1234")
        {
            Result.text = "Unlocked";
        }

        else if (SentCommand == "sigge")
        {
            sigge.SetActive(true);
        }
    }
}
