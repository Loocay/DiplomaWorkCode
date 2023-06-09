using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;

    public bool IsDead()
    {
        return isDead; 
    }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;

        if(hitPoints <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        if (isDead) return;
        isDead= true;
        GetComponent<Animator>().SetTrigger("Death");
    }
}

