using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(5, 0, 0);
            transform.localScale = new Vector3(0.5f,0.5f,1);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(0,0,0);
            transform.localScale = new Vector3(1.5f,1.5f,1);
        }

    }
}
