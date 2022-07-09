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
        player.health = health.health;
        player.coin = int.Parse(Coin.text);
        player.sword = int.Parse(Sword.text);
        player.potion = int.Parse(Potion.text);

        SaveSystem.SavePlayer(player);
    }
}
