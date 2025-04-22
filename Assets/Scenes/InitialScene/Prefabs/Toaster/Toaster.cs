using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toaster : MonoBehaviour
{

  public Item item;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void ToggleToaster()
  {

    // Get the item from the player's inventory.
    Inventory inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
    
    if (this.item != null) {

      if (inventory.items.Count + 1 <= inventory.slotCount) {

        inventory.items.Add(this.item);
        this.item = null;

      }

    } else {

      
      if (inventory.items.Count > 0) {

        Item item = inventory.items[^1];
        inventory.items.RemoveAt(0);
        this.item = item;

      }

    }

  }

}
