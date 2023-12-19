using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    private bool PaperInput;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PaperInput = true;
            transform.position = new Vector2(0, 0);

            transform.localScale = new Vector3 (13, 13, 1);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PaperInput = false;
            transform.position = new Vector2(-8, -4);

            transform.localScale = new Vector3(3, 3, 1);
        }
        if(PaperInput)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                transform.position = new Vector3(1,0,1);
                transform.position = new Vector3(0, 0, 1);
            }
        }
    }
}
