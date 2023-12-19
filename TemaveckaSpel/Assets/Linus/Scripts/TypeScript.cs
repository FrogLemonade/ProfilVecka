using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeScript : MonoBehaviour
{
    public TMP_InputField TerminalInput;
    public string sentcommand;

    public void TextToCommand()
    {
        sentcommand = TerminalInput.text;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
