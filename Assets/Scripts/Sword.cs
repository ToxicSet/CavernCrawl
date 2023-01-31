using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
    private Animator animator;
    public List<BaseStat>  Stats { get; set; }

    void Start() 
    { 
        animator = GetComponent<Animator>();

    }    
    public void PerformAttack()
    {
        animator.SetTrigger("BaseAttack");
        Debug.Log(this.name + "Sword attack!");
    }

    public void PerformSpecialAttack()
    {
        animator.SetTrigger("Special_Attack");
        Debug.Log(this.name + "Sword attack!");
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hit: " + collider.name);
        if (collider.tag == "Enemy")
        {
            collider.GetComponent<IEnemy>().TakeDamage(Stats[0].GetCalculatedStatValue());

        }
    }


}
