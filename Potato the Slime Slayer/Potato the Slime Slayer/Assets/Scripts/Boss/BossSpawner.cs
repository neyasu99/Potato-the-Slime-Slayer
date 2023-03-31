using UnityEngine;
using UnityEngine.SceneManagement;

public class BossSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Boss;

    void Start()
    {
        var bossHealth = Boss.GetComponent<Health>();
        bossHealth.health = 100;
        bossHealth.MAX_HEALTH = 100;
        Boss.transform.localScale = new Vector3(2f, 2f, Boss.transform.localScale.z);
        spawnBoss(Boss, new Vector3(Random.Range(-1.82f, 1.82f), 1.03f, -1.82f));
    }

    public void spawnBoss(GameObject boss, Vector3 position)
    {
        new WaitForSecondsRealtime(2f);
        GameObject newEnemy = Instantiate(boss, position, Quaternion.identity);
    }
}
