using UnityEngine;

public class PlayerAttacArea : MonoBehaviour
{
    private int damage = 5;

    public Player Player;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();

            damage = damage + Player.sword;

            health.Damage(damage);
        }
    }
}
