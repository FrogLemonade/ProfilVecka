using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public class ComputerScript : MonoBehaviour
{
    public GameObject Computer;
    public GameObject MovePoint;
    public GameObject TerminalInputWindow;
    public GameObject TerminalInputWindow1;
    public float moveSpeed;
    public float Duration;
    public float elapsedTime;
    private Vector3 startpos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Computer.transform.position = Vector3.MoveTowards(Computer.transform.position, MovePoint.transform.position, moveSpeed);
        
        elapsedTime += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.D))
        {
            elapsedTime = 0;
            
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            elapsedTime = 1;
        }
        
        float percentageComplete = elapsedTime / Duration;


        Computer.transform.localScale = Vector3.Lerp(Computer.transform.localScale, MovePoint.transform.localScale, percentageComplete);

        if(Computer.transform.position == new Vector3(0,0,0))
        {
            TerminalInputWindow.SetActive(true);
            TerminalInputWindow1.SetActive(true);
        }
        else
        {
            TerminalInputWindow.SetActive(false);
            TerminalInputWindow1.SetActive(false);
        }

    }
    
}
