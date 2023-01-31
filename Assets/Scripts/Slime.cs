using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour, IEnemy
{
    public float currenthealth, power, toughness;
    public float maxHealth;

    void Start()
    {
        currenthealth = maxHealth;
    }


    public void PerformAttack()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage(int amount)
    {
        currenthealth -= amount;
        if(currenthealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
