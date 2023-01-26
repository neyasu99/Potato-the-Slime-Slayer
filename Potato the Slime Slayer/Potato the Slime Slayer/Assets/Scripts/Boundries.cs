using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundries : MonoBehaviour
{
    private Vector2 screenBoundries;
    
    void Start()
    {
        screenBoundries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void LateUpdate()
    {
        Vector3 viewPosition = transform.position;

        if (screenBoundries.x < viewPosition.x)
            viewPosition.x = screenBoundries.x;
        else if (screenBoundries.x * -1 > viewPosition.x)
            viewPosition.x = screenBoundries.x * -1;

        transform.position = viewPosition;
    }
}
