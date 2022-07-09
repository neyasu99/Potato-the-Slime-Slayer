using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerLoot : MonoBehaviour
{
    [SerializeField]
    private Text Coin;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag.Equals("Coin"))
        {
            Coin.text = (int.Parse(Coin.text) + 1).ToString();
            Destroy(collider.gameObject);
        }
    }
}
