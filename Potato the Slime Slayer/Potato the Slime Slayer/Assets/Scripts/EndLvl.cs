using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLvl : MonoBehaviour
{
    [SerializeField]
    private int enemiesLeft;

    // Update is called once per frame
    void Update()
    {
        CheckEnemies();
    }

    private void CheckEnemies()
    {
        enemiesLeft = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemiesLeft <= 0)
        {
            SceneManager.LoadScene("EndLvl");
        }
    }
}
