using UnityEngine;

public class EndLvl : MonoBehaviour
{
    [SerializeField]
    private int enemiesLeft;

    [SerializeField]
    private GameObject sign;

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
            sign.SetActive(true);
        }
    }
}
