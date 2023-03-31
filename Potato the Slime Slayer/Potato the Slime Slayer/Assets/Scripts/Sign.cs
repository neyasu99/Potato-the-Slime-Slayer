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
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "NPC")
            SceneManager.LoadScene(sceneName);
        else
        {
            Player = GameObject.Find("Player");
            Player playerFromComponent = Player.GetComponent<Player>();
            if (playerFromComponent.Lvl % 10 == 0)
                SceneManager.LoadScene("BossLvl");
            else if (playerFromComponent.Lvl % 3 == 0)
                SceneManager.LoadScene("NPC");
            else
                SceneManager.LoadScene(sceneName);
        }
    }

    public void SaveScene(Player player)
    {
        Player = GameObject.Find("Player");
        Player playerFromComponent = Player.GetComponent<Player>();
        PlayerHealth health = Player.GetComponent<PlayerHealth>();
        player.HP = health.health;
        player.Money = int.Parse(Coin.text);
        player.Strength = playerFromComponent.Strength;
        player.HPItem = int.Parse(Potion.text);
        player.StepCount = playerFromComponent.StepCount;
        player.JumpCount = playerFromComponent.JumpCount;
        player.DeathCount = playerFromComponent.DeathCount;
        player.Lvl = playerFromComponent.Lvl;
        player.HitCount = playerFromComponent.HitCount;

        SaveSystem.SavePlayer(player);
    }
}
