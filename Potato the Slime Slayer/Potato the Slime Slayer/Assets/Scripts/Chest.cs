using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Chest : MonoBehaviour, IPointerClickHandler
{
    public GameObject loot;
    public GameObject potion;
    public GameObject coin;
    private GameObject Player;
    private PlayerHealth health;
    private bool lootShown = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        Player = GameObject.Find("Player");
        health = Player.GetComponent<PlayerHealth>();
        if (!lootShown)
            changeLootActive(health);
    }

    void changeLootActive(PlayerHealth health)
    {
        loot.SetActive(true);
        if (Int32.Parse(health.health.ToString()) > 25)
            coin.SetActive(true);
        else
            potion.SetActive(true);
        lootShown = true;
    }
}
