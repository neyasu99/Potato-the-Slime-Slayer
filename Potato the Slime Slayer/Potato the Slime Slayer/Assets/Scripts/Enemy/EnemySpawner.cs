using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Enemy;


    private GameObject Player;
    private Player player;
    private Enemy enemy;
    private float enemiesNumber;

    void Start()
    {
        Player = GameObject.Find("Player");
        player = Player.GetComponent<Player>();
        enemy = Enemy.GetComponent<Enemy>();
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "FirstLvl")
        {
            enemiesNumber = 2;
        }
        else
        {
            enemiesNumber = player.Strength * player.Speed + player.Lvl;
            Enemy.GetComponent<SpriteRenderer>().color = new Color(255, enemy.enemyStrength, 255, enemy.enemyStrength);
            enemy.enemyStrength = enemy.enemyStrength + player.Lvl;
            enemy.enemySpeed = enemy.enemySpeed + (player.Lvl * 0.05f);
        }

        while (enemiesNumber >= 1)
        {
            enemiesNumber--;
            spawnEnemy(Enemy);
        }
    }

    private void spawnEnemy(GameObject enemy)
    {
        new WaitForSecondsRealtime(2f);
        //uziemić enamy żeby mógł spadać/skakać
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-1.82f, 1.82f), 1.03f, -1.82f), Quaternion.identity);
    }

    void Update()
    {

    }
}
