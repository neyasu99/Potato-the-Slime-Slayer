using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CoinUp : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Text Coin;
    public GameObject CoinObject;
    public GameObject Loot;
    public GameObject Chest;

    public void OnPointerClick(PointerEventData eventData)
    {
        Coin.text = (Int32.Parse(Coin.text) + 1).ToString();
        CoinObject.SetActive(false);
        Loot.SetActive(false);
        Chest.SetActive(false);
    }
}
