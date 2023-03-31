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
            WeaponPrice.text = (Int32.Parse(Weapon.text) * 2).ToString();
            PotionPrice.text = (Int32.Parse(Potion.text) * 3).ToString();
            int coin = Int32.Parse(Coin.text);
            int weaponPrice = Int32.Parse(WeaponPrice.text);
            int potionPrice = Int32.Parse(PotionPrice.text);
            if (coin < weaponPrice)
                WeaponPrice.color = Color.red;
            if(coin < potionPrice)
                PotionPrice.color = Color.red;
        }

        if(MarketFrame.enabled == true)
        {
            PlayerData data = SaveSystem.LoadPlayer();

            int weaponPrice = Int32.Parse(Weapon.text);
            if (data.Lvl / 3 == 0) 
            {
                WeaponPrice.text = "2";
            }
            else
            {
                WeaponPrice.text = ((weaponPrice * 2) + (data.Lvl / 3)).ToString();
            }

            int potionPrice = Int32.Parse(Potion.text);
            if (data.Lvl / 3 == 0)
            {
                PotionPrice.text = "3";
            }
            else
            {
                PotionPrice.text = ((potionPrice * 3) + (data.Lvl / 3)).ToString();
            }
        }
    }
}
