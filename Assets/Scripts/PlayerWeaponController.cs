using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    public GameObject playerHand;
    public GameObject EquippedWeapon { get; set; }

    IWeapon equippedWeapon;
    CharacterStats characterStats;

    private void Start()
    {
        characterStats = GetComponent<CharacterStats>();
    }
    public void EquipWeapon(Item iteamToEquip)
    {
        //If weapon is unequiped removes stats
        if (EquippedWeapon != null)
        {
            characterStats.RemoveStatBonus(EquippedWeapon.GetComponent<IWeapon>().Stats);
            Destroy(playerHand.transform.GetChild(0).gameObject);
        }
        //Equiping Weapon
        EquippedWeapon = (GameObject)Instantiate(Resources.Load<GameObject>("Weapon/" + iteamToEquip.ObjectSlug), playerHand.transform.position, playerHand.transform.rotation);
        equippedWeapon = EquippedWeapon.GetComponent<IWeapon>();
        equippedWeapon.Stats = iteamToEquip.Stats;
        EquippedWeapon.transform.SetParent(playerHand.transform);
        //adding stats on equip
        characterStats.AddStatBonus(iteamToEquip.Stats);
        Debug.Log(equippedWeapon.Stats[0].GetCalculatedStatValue());

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) 
        {
            PerformWeaponAttack();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            PerformSpecialAttack();
        }
    }

    public void PerformWeaponAttack()
    {
        equippedWeapon.PerformAttack();
    }

    public void PerformSpecialAttack()
    {
        equippedWeapon.PerformSpecialAttack();
    }

}
