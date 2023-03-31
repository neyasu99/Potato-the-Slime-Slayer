using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public int health;

    [SerializeField]
    private int MAX_HEALTH = 100;

    public PlayerHealthBar healthBar;
    private PlayerData Player;

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "FirstLvl")
        {
            health = 100;
        }
        else
        {
            Player = SaveSystem.LoadPlayer();
            health = Player.HP;
        }

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

        SceneManager.LoadScene("KillScreen");
    }
}
