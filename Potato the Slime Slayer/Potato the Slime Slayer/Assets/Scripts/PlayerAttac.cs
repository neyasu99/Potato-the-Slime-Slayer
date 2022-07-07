using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttac : MonoBehaviour
{
    private GameObject attacArea = default;
    private bool attacking = false;
    public Animator animator;

    void Start()
    {
        attacArea = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

        if (attacking)
        {
            attacking = false;
            attacArea.SetActive(attacking);
        }
    }

    private void Attack()
    {
        attacking = true;
        attacArea.SetActive(attacking);
        animator.SetTrigger("Attac");
    }
}
