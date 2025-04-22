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

  public void AddItemToToaster()
  {

    // Get the item from the player's inventory.
    List<Item> items = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().items;
    if (items.Count > 0) {

      Item item = items[^1];
      items.RemoveAt(0);
      this.item = item;

    }

  }

}
