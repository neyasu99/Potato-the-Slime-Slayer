using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLvlStartObjects : MonoBehaviour
{
    public GameObject platform;

    void Start()
    {
        platform.layer = LayerMask.NameToLayer("Foreground"); ;
        Instantiate(platform, new Vector3(-1.5f, 1.5f, -1.82f), Quaternion.identity);
    }
}
