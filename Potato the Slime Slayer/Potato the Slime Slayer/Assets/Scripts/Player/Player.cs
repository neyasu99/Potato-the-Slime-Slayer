using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int HP = 100;
    public int Strength = 5;
    public float Speed = 5f;
    public int Step = 1;
    public int StepCount = 0;
    public float Jump = 10f;
    public int JumpCount = 0;
    public DateTime TimeOnLvl = new DateTime();
    public DateTime TimeInGame = new DateTime();
    public int DeathCount = 0;
    public int BossDeathCount = 0;
    public int Money = 0;
    public int MoneySpend = 0;
    public int ItemsUsed = 0;
    public int HPItem = 0;
    public int StrengthItem = 0;
    public int HitCount = 0;
    public int Size = 1;
    public int Lvl = 0;

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

        HP = data.HP;
        Strength = data.Strength;
        Speed = data.Speed;
        Step = data.Step;
        StepCount = data.StepCount;
        Jump = data.Jump;
        JumpCount = data.JumpCount;
        TimeOnLvl = data.TimeOnLvl;
        TimeInGame = data.TimeInGame;
        DeathCount = data.DeathCount;
        BossDeathCount = data.BossDeathCount;
        Money = data.Money;
        MoneySpend = data.MoneySpend;
        ItemsUsed = data.ItemsUsed;
        HPItem = data.HPItem;
        StrengthItem = data.StrengthItem;
        HitCount = data.HitCount;
        Size = data.Size;
        Lvl = data.Lvl;
    }
}
