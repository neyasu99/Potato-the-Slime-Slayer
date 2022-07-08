using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttac : MonoBehaviour
{
    private GameObject attacArea = default;
    private bool attacking = false;
    private float timeToAttac = 0.25f;
    private float timer = 0f;
    public Animator animator;

    void Start()
    {
        attacArea = transform.GetChild(1).gameObject;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
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

    private void Attack()
    {
        attacking = true;
        attacArea.SetActive(attacking);
        animator.SetTrigger("Attac");
    }
}
