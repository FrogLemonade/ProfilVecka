using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObject : MonoBehaviour
{
    public GameObject Paper;
    public GameObject MovePoint;
    public float speed;
    public float Duration = 3f;
    public float elapsedTime;

    // Update is called once per frame
    void Update()
    {   
        Paper.transform.position = Vector2.MoveTowards(Paper.transform.position, MovePoint.transform.position, speed);

        elapsedTime += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.A))
        {
            elapsedTime = 0;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            elapsedTime = 1;
        }

        float percentageComplete = elapsedTime / Duration;

        transform.localScale = Vector3.Lerp(Paper.transform.localScale, MovePoint.transform.localScale, percentageComplete);
    }
}
