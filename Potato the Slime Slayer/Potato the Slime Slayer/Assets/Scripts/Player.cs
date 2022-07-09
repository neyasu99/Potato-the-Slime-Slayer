using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public int coin = 0;
    public int sword = 1;
    public int potion = 0;
    public int jump = 0;
    public int hit = 0;
    public float time = 0f;

    private void Start()
    {
        LoadPlayer();
    }

    private void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    private void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        health = data.health;
        coin = data.coin;
        sword = data.sword;
        potion = data.potion;
        jump = data.jump;
        hit = data.hit;
        time = data.time;
    }
}
