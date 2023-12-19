using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector2(0, 0);

            transform.localScale = new Vector3 (7, 7, 1);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = new Vector2(-8, -4);

            transform.localScale = new Vector3(3, 3, 1);

        }
    }
}
