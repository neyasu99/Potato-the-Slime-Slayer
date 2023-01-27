using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    public GameObject Player;

    private Player player;
    private float enemiesNumber;

    void Start()
    {
        Player = GameObject.Find("Player");
        player = Player.GetComponent<Player>();
        Scene scene = SceneManager.GetActiveScene();
        enemiesNumber = Random.Range(1, 5);

        if (scene.name == "FirstLvl")
        {
            enemiesNumber = 2;
        }
        else
        {
            enemiesNumber = player.Strength * player.Speed;
            enemy.GetComponent<Enemy>().enemyStrength = enemy.GetComponent<Enemy>().enemyStrength + player.Lvl;
            enemy.GetComponent<Enemy>().enemySpeed = enemy.GetComponent<Enemy>().enemySpeed + (player.Lvl * 0.05f);
        }

        while (enemiesNumber >= 1)
        {
            enemiesNumber--;
            spawnEnemy(enemy);
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
