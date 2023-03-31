using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLvl : MonoBehaviour
{
    [SerializeField]
    private int enemiesLeft;

    [SerializeField]
    private GameObject sign;

    public GameObject chest;

    private bool showChest = false;

    private GameObject Player;
    private Player player;
    private string enamyTag;

    public GameObject boss;

    private int bossRound = 1; 
    float y = 1.03f;

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "BossLvl")
        {
            enamyTag = "Boss";
        }
        else
            enamyTag = "Enemy";
    }

    void Update()
    {
        if (!showChest)
            CheckEnemies(enamyTag);
    }

    private void CheckEnemies(string enamyTag)
    {
        enemiesLeft = GameObject.FindGameObjectsWithTag(enamyTag).Length;

        if (enemiesLeft <= 0)
        {
            if(enamyTag == "Boss")
            {
                if (bossRound < 6)
                {
                    bossRound++;

                    var bossParameters = boss.GetComponent<Boss>();
                    bossParameters.bossSpeed += 0.1f;

                    boss.transform.localScale = new Vector3((boss.transform.localScale.x - 0.3f), (boss.transform.localScale.y - 0.3f), boss.transform.localScale.z);
                    BossSpawner bossSpawner = new BossSpawner();
                    int newBosses = bossRound;

                    y = y - 0.05f;

                    while (newBosses > 0)
                    {
                        bossSpawner.spawnBoss(boss, new Vector3(Random.Range(-1.82f, 1.82f), 0.82f, -1.82f));
                        newBosses--;
                    }
                }
                else
                {
                    ShowChest();
                    SaveLvl();
                }
            }
            else
            {
                ShowChest();
                SaveLvl();
            }
        }
    }

    private void ShowChest()
    {
        showChest = true;
        chest.SetActive(true);
    }

    private void SaveLvl()
    {
        sign.SetActive(true);

        Player = GameObject.Find("Player");
        player = Player.GetComponent<Player>();
        player.Lvl++;
    }
}
