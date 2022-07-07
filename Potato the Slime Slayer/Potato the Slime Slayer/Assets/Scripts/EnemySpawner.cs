using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private float enemiesNumber;

    void Start()
    {
        while (enemiesNumber > 1)
        {
            enemiesNumber--;
            spawnEnemy(enemy);
        }
    }

    private void spawnEnemy(GameObject enemy)
    {
        new WaitForSecondsRealtime(2f);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), 1, -1.827229f), Quaternion.identity);
    }

    void Update()
    {

    }
}
