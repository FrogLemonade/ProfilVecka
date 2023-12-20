using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WritingScript : MonoBehaviour
{

    public Text wordOutput = null;

    private string remainingword = string.Empty;
    private string currentword = "switch";
    public int activeMonster = 1;
    private void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord()
    {
        SetRemainingWord(currentword);
    }


    private void SetRemainingWord(string newString)
    {
        remainingword = newString;
        wordOutput.text = remainingword;
    }

    // Update is called once per frame
    private void Update()
    {
        Checkinput();
        if(activeMonster >6)
        {
            activeMonster = 1;
        }
    }

    private void Checkinput()
    {
        if (Input.anyKey)
        {
            string keysPressed = Input.inputString;

            if(keysPressed.Length == 1)
            {
                EnterLetter(keysPressed);
            }
        }
    }

    private void EnterLetter(string TypedLetter)
    {
         if(IsCorrectLetter(TypedLetter))
        {
            RemoveLetter();

            if (IsWordComplete())
            {
                activeMonster += 1;
                SetCurrentWord();
            }
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingword.IndexOf(letter) == 0;

    }

    private void RemoveLetter()
    {
        string newString = remainingword.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool IsWordComplete()
    {
       
        return remainingword.Length == 0;
        
    }
}
