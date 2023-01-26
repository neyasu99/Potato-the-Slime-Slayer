using UnityEngine;

public class EndLvl : MonoBehaviour
{
    [SerializeField]
    private int enemiesLeft;

    [SerializeField]
    private GameObject sign;

    public GameObject coin;

    private bool showChest = false;

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
        }
    }

    private void ShowChest()
    {
        showChest = true;
        Instantiate(coin, new Vector3(0, 0.8f, -1.82f), Quaternion.identity);
    }
}
