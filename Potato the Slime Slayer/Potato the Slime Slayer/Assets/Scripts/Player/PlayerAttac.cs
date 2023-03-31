using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttac : MonoBehaviour
{
    private GameObject attacArea = default;
    private bool attacking = false;
    private float timeToAttac = 0.25f;
    private float timer = 0f;
    public Animator animator; 
    private GameObject Player; 
    private int enemiesLeft;
    private string enemyTag;
    private Scene scene;

    void Start()
    {
        attacArea = transform.GetChild(1).gameObject;
        Player = GameObject.Find("Player");
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "BossLvl")
            enemyTag = "Boss";
        else if(scene.name == "FirstLvl" || scene.name == "Lvl")
            enemyTag = "Enemy";
    }

    void Update()
    {
        enemiesLeft = GameObject.FindGameObjectsWithTag(enemyTag).Length;
        if (enemiesLeft > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Attack();
                Player.GetComponent<Player>().HitCount++;
            }

            if (attacking)
            {
                timer += Time.deltaTime;

                if (timer >= timeToAttac)
                {
                    timer = 0;
                    attacking = false;
                    attacArea.SetActive(attacking);
                }
            }
        }
    }

    private void Attack()
    {
        attacking = true;
        attacArea.SetActive(attacking);
        animator.SetTrigger("Attac");
    }
}
