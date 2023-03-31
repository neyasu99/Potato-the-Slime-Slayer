using UnityEngine;

public class PlayerAttacArea : MonoBehaviour
{
    private int damage = 10;

    public Player Player;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();

            damage = damage + Player.Strength;

            health.Damage(damage);
        }
    }
}
