using UnityEngine;

public class EndLvl : MonoBehaviour
{
    [SerializeField]
    private int enemiesLeft;

    [SerializeField]
    private GameObject sign;

    public GameObject coin;

    private bool showChest = false;

    private GameObject Player;
    private Player player;

    // Update is called once per frame
    void Update()
    {
        if (!showChest)
            CheckEnemies();
    }

    private void CheckEnemies()
    {
        enemiesLeft = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemiesLeft <= 0)
        {
            ShowChest();
            sign.SetActive(true);

            Player = GameObject.Find("Player");
            player = Player.GetComponent<Player>();
            player.Lvl++;
        }
    }

    private void ShowChest()
    {
        showChest = true;
        Instantiate(coin, new Vector3(0, 0.8f, -1.82f), Quaternion.identity);
    }
}
