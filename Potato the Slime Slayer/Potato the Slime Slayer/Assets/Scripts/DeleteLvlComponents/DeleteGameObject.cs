using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlatform : MonoBehaviour
{
    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}
