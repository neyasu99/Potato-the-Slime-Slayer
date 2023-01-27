using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    [SerializeField]
    public Text Coin;

    [SerializeField]
    public Text Sword;

    [SerializeField]
    public Text Potion;

    [SerializeField]
    public GameObject Player;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SaveScene(Player player)
    {
        Player = GameObject.Find("Player");
        Health health = Player.GetComponent<Health>();
        player.HP = health.health;
        player.Money = int.Parse(Coin.text);
        player.Strength = int.Parse(Sword.text);
        player.HPItem = int.Parse(Potion.text);
        player.StepCount = Player.GetComponent<Player>().StepCount;
        player.JumpCount = Player.GetComponent<Player>().JumpCount;
        player.DeathCount = Player.GetComponent<Player>().DeathCount;
        player.Lvl = Player.GetComponent<Player>().Lvl + 1;
        player.HitCount = Player.GetComponent<Player>().HitCount;

        SaveSystem.SavePlayer(player);
    }
}
