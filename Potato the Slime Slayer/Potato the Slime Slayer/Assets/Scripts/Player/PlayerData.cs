using System;

[System.Serializable]
public class PlayerData
{
    public int HP;
    public int Strength;
    public float Speed;
    public int Step;
    public int StepCount;
    public float Jump;
    public int JumpCount;
    public DateTime TimeOnLvl;
    public DateTime TimeInGame;
    public int DeathCount;
    public int BossDeathCount;
    public int Money;
    public int MoneySpend;
    public int ItemsUsed;
    public int HPItem;
    public int HitCount;
    public int Size;
    public int Lvl;

    public PlayerData(Player player)
    {
        HP = player.HP;
        Strength = player.Strength;
        Speed = player.Speed;
        Step = player.Step;
        StepCount = player.StepCount;
        Jump = player.Jump;
        JumpCount = player.JumpCount;
        TimeOnLvl = player.TimeOnLvl;
        TimeInGame = player.TimeInGame;
        DeathCount = player.DeathCount;
        BossDeathCount = player.BossDeathCount;
        Money = player.Money;
        MoneySpend = player.MoneySpend;
        ItemsUsed = player.ItemsUsed;
        HPItem = player.HPItem;
        HitCount = player.HitCount;
        Size = player.Size;
        Lvl = player.Lvl;
    }
}
