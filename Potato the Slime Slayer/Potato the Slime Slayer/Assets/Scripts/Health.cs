using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int health = 100;

    [SerializeField]
    private int MAX_HEALTH = 100;

    public HealthBar healthBar;

    public GameObject coin;

    private void Start()
    {
        health = MAX_HEALTH;
        healthBar.SetMaxHealth(MAX_HEALTH);
    }

    public void Damage(int amount)
    {
        if (amount < 0)
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");

        this.health -= amount;

        healthBar.SetHealth(this.health);

        if (health <= 0)
            Die();
    }

    public void Heal(int amount)
    {
        if (amount < 0)
            throw new System.ArgumentOutOfRangeException("Cannot have negative Healing");

        if (health + amount > MAX_HEALTH)
            this.health = MAX_HEALTH;
        else
            this.health += amount;

        healthBar.SetHealth(this.health);
    }

    private void Die()
    {
        Debug.Log("I am Dead!");

        if (gameObject.tag.Equals("Enemy"))
        {
            int amound = Random.Range(1, 3);
            while (amound > 0)
            {
                Instantiate(coin, new Vector3(gameObject.transform.position.x - 1, 0.8f, -1), Quaternion.Euler(0f, 0f, 0f));
                amound--;
            }
        }
        else
        {
            SceneManager.LoadScene("Lvl");
        }

        Destroy(gameObject);
    }
}
