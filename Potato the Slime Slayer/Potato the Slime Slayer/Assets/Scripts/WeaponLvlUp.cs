using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WeaponLvlUp : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Text Coin;

    [SerializeField]
    private Text Weapon;

    [SerializeField]
    private Text Price;

    public void OnPointerClick(PointerEventData eventData)
    {
        int coin = Int32.Parse(Coin.text);
        int price = Int32.Parse(Price.text.Remove(0, 1));
        if (coin > 0 && price < coin)
        {
            Weapon.text = (Int32.Parse(Weapon.text) + 1).ToString();
            Coin.text = (coin - price).ToString();
            Price.text = "-" + (price * 2).ToString();
        }
        else
        {
            Price.color = Color.red;
        }
    }

    void Start()
    {
    }

    void Update()
    {
    }
}
