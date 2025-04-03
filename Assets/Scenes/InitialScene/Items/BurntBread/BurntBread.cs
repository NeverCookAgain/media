using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurntBread : Item
{

    public override void Activate() 
    {

        // Remove the item from the player's inventory.
        GameObject inventoryGameObject = GameObject.FindGameObjectWithTag("Inventory");
        Inventory inventory = inventoryGameObject.GetComponent<Inventory>();
        inventory.items.Remove(this);

    }
}
