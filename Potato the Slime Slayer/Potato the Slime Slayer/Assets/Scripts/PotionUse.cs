using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PotionUse : MonoBehaviour, IPointerClickHandler
{
    public Text Potion;
    private GameObject Player;
    private PlayerHealth health;

    public void OnPointerClick(PointerEventData eventData)
    {
        Player = GameObject.Find("Player");
        health = Player.GetComponent<PlayerHealth>();

        int potionCount = Int32.Parse(Potion.text);

        if (potionCount > 0)
        {
            Potion.text = (potionCount - 1).ToString();
            health.Heal(50);
        }
    }
}
