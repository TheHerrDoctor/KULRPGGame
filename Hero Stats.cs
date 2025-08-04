using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStats : FighterStats
{
    
    void Start()
    {
        //s¹ staty z fightera, tutaj dodaje dodatkowe staty z EQ
        EQManager.instance.onEQChanged += OnEQChanged;
    }

    void OnEQChanged(Equipment newItem, Equipment oldItem)
    {
        if (newItem != null)
        {
            //maxHealth.AddModifier(newItem.maxHealthModifier)
            atack.AddModifier(newItem.atackModifier);
            defence.AddModifier(newItem.defenceModifier);
            magic.AddModifier(newItem.magicModifier);
            resistance.AddModifier(newItem.resistanceModifier);
            speed.AddModifier(newItem.speedModifier);
            move.AddModifier(newItem.moveModifier);
        }

        if (oldItem != null)
        {
            //maxHealth.RemoveModifier(newItem.maxHealthModifier)
            atack.RemoveModifier(oldItem.atackModifier);
            defence.RemoveModifier(oldItem.defenceModifier);
            magic.RemoveModifier(oldItem.magicModifier);
            resistance.RemoveModifier(oldItem.resistanceModifier);
            speed.RemoveModifier(oldItem.speedModifier);
            move.RemoveModifier(oldItem.moveModifier);
        } 
    }
}
