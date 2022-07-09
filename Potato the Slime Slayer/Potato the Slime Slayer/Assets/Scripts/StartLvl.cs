using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartLvl : MonoBehaviour
{
    [SerializeField]
    Text Coin;

    [SerializeField]
    Text Weapon;

    [SerializeField]
    Text Potion;
    
    void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Coin.text = data.coin.ToString();
        Weapon.text = data.sword.ToString();
        Potion.text = data.potion.ToString();
    }
}
