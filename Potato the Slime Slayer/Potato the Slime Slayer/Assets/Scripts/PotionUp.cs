using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PotionUp : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Text Coin;

    [SerializeField]
    private Text Potion;

    [SerializeField]
    private Text Price;

    public void OnPointerClick(PointerEventData eventData)
    {
        int coin = Int32.Parse(Coin.text);
        int price = Int32.Parse(Price.text);
        if (coin > 0 && price < coin)
        {
            Potion.text = (Int32.Parse(Potion.text) + 1).ToString();
            Coin.text = (coin - price).ToString();
            Price.text = (price * 3).ToString();
        }
        else
        {
            Price.color = Color.red;
        }
    }
}
