[System.Serializable]
public class PlayerData
{
    public int health;
    public int coin;
    public int sword;
    public int potion;
    public int jump;
    public int hit;
    public float time;

    public PlayerData(Player player)
    {
        health = player.health;
        coin = player.coin;
        sword = player.sword;
        potion = player.potion;
        jump = player.jump;
        hit = player.hit;
        time = player.time;
    }
}
