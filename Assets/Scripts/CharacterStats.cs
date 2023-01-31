using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
  public List<BaseStat> Stats = new List<BaseStat>();

    private void Start()
    {
        //seting base stat
        Stats.Add(new BaseStat(4, "Power", "YourPower"));
        Stats.Add(new BaseStat(5, "Vitality", "Your Vital"));
    }

    public void AddStatBonus(List<BaseStat> statBonuses)
    {
        //finds base stat and sends info to the stat bonus method
        foreach(BaseStat statBonus in statBonuses)
        {
            Stats.Find(x => x.StatName == statBonus.StatName).AddStatBonus(new StatBonus(statBonus.BaseValue));
        }
    }

    public void RemoveStatBonus(List<BaseStat> statBonuses)
    {
        //finds base stat and sends info to the stat bonus method
        foreach (BaseStat statBonus in statBonuses)
        {
            Stats.Find(x => x.StatName == statBonus.StatName).RemoveStateBonus(new StatBonus(statBonus.BaseValue));
        }
    }

}
