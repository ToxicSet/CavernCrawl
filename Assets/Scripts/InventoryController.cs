using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public PlayerWeaponController playerWeaponController;
    public ConsumableController consumableController;
    public Item sword;
    public Item PotionLog;

    private void Start()
    {
        //sword for player
        playerWeaponController= GetComponent<PlayerWeaponController>();
        //Consumables
        consumableController = GetComponent<ConsumableController>();
        List<BaseStat> swordStats = new List<BaseStat>();
        swordStats.Add(new BaseStat(6, "Power", "Your Power"));
        sword = new Item(swordStats, "sword");
        
        PotionLog = new Item(new List<BaseStat>(), "Potion_Log", "Drink this to log something cool!", "Drink", "Log Potion", false);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            playerWeaponController.EquipWeapon(sword);
            consumableController.ConsumeItem(PotionLog);
        }
    }
}
