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

    public GameObject PotionObject;
    public GameObject Loot;
    public GameObject Chest;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Price != null)
        {
            int coin = Int32.Parse(Coin.text);
            int price = Int32.Parse(Price.text);
            PlayerData data = SaveSystem.LoadPlayer();
            if (coin > 0 && price <= coin)
            {
                Potion.text = (Int32.Parse(Potion.text) + 1).ToString();
                Coin.text = (coin - price).ToString();
                Price.text = ((price * 3) + (data.Lvl / 3)).ToString();
            }
            else
            {
                Price.color = Color.red;
            }
        }
        else
        {
            Potion.text = (Int32.Parse(Potion.text) + 1).ToString();
            PotionObject.SetActive(false);
            Loot.SetActive(false);
            Chest.SetActive(false);
        }
        
    }
}
