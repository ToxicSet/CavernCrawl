using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public PlayerWeaponController playerWeaponController;
    public Item sword;

    private void Start()
    {
        playerWeaponController= GetComponent<PlayerWeaponController>();
        List<BaseStat> swordStats = new List<BaseStat>();
        swordStats.Add(new BaseStat(6, "Power", "Your Power"));
        sword = new Item(swordStats, "sword");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            playerWeaponController.EquipWeapon(sword);
        }
    }
}
