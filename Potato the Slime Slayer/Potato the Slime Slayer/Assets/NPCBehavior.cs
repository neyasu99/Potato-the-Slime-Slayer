using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCBehavior : MonoBehaviour
{
    [SerializeField]
    private Text Talk;

    [SerializeField]
    private Text Coin;

    [SerializeField]
    private Text Weapon;

    [SerializeField]
    private Text Potion;

    [SerializeField]
    private Image MarketFrame;

    [SerializeField]
    private GameObject MarketWeapon;

    [SerializeField]
    private Text WeaponPrice;

    [SerializeField]
    private GameObject MarketPotion;

    [SerializeField]
    private Text PotionPrice;

    void Start()
    {
        Talk.enabled = false;
        MarketFrame.enabled = false;
        MarketWeapon.SetActive(false);
        MarketPotion.SetActive(false);
        Coin.text = "20";
        Weapon.text = "1";
        Potion.text = "1";
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Player")
        {
            Talk.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Player")
        {
            Talk.enabled = false;
            if (MarketFrame.enabled == true)
            {
                MarketFrame.enabled = false;
                MarketWeapon.SetActive(false);
                MarketPotion.SetActive(false);
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T) && Talk.enabled == true)
        {
            Talk.enabled = false;
            MarketFrame.enabled = true;
            MarketWeapon.SetActive(true);
            MarketPotion.SetActive(true);
            WeaponPrice.text = "-" + (Int32.Parse(Weapon.text) * 2).ToString();
            PotionPrice.text = "-" + (Int32.Parse(Potion.text) * 2).ToString();
            int coin = Int32.Parse(Coin.text);
            int weaponPrice = Int32.Parse(WeaponPrice.text);
            int potionPrice = Int32.Parse(PotionPrice.text);

            CheckPrices(coin, weaponPrice, WeaponPrice);
            CheckPrices(coin, potionPrice, PotionPrice);
        }

        void CheckPrices(int coin, int price, Text Price)
        {
            if (coin < price)
                Price.color = Color.red;
        }
    }
}
