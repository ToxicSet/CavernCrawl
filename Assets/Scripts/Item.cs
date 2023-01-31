using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public List<BaseStat> Stats { get; set; }
    public string ObjectSlug { get; set; }
    public string Discription { get; set; }
    public string ActionName { get; set; }
    public string ItemName { get; set; }
    public bool ItemModifier {get; set;}

    public Item(List<BaseStat> _Stats, string objectSlug)
    {
        this.Stats = _Stats;
        this.ObjectSlug = objectSlug;
    }

        public Item(List<BaseStat> _Stats, string objectSlug, string Discription, string ItemName, string ActionName, bool ItemModifier)
    {
        this.Stats = _Stats;
        this.ObjectSlug = objectSlug;
        this.Discription = Discription;
        this.ActionName = ActionName;
        this.ItemName = ItemName;
        this.ItemModifier = ItemModifier;
    }
}
