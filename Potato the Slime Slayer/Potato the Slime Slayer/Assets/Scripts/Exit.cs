using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Player player = new Player();
        player.Lvl = 1;
        player.Strength = 5;
        player.Money = 0;
        player.HPItem = 0;
        player.StrengthItem = 0;
        player.HP = 100;

        SaveSystem.SavePlayer(player);

        SceneManager.LoadScene(sceneName);
    }
}
