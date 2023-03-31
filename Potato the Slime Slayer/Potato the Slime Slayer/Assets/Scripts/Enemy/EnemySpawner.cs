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
            enemiesNumber = Random.Range(2, 5) + (player.Lvl * 0.3f);
            Enemy.GetComponent<SpriteRenderer>().color = new Color(255, enemy.enemyStrength, 255, enemy.enemyStrength);
            enemy.enemyStrength = 5;
            enemy.enemySpeed = 0.5f;
        }

        while (enemiesNumber >= 1)
        {
            enemiesNumber--;
            spawnEnemy(Enemy, new Vector3(Random.Range(-1.82f, 1.82f), 1.03f, -1.82f));
        }
    }

    private void spawnEnemy(GameObject enemy, Vector3 position)
    {
        new WaitForSecondsRealtime(2f);
        GameObject newEnemy = Instantiate(enemy, position, Quaternion.identity);
    }
}
