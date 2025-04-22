using System.Collections;
using UnityEngine;

public class Toaster : MonoBehaviour
{

  public Item item;
  private IEnumerator cookingProcess;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public IEnumerator CookItem()
  {

    while (item && item.GetBurnLevel() != BurnLevel.Burnt)
    {
      yield return new WaitForSeconds(3);
      item.SetBurnLevel(item.GetBurnLevel() == BurnLevel.NotCooked ? BurnLevel.Cooked : BurnLevel.Burnt);
    }

  }

  public void ToggleToaster()
  {

    // Get the item from the player's inventory.
    Inventory inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();

    if (this.item != null)
    {

      StopCoroutine(cookingProcess);

      if (inventory.items.Count + 1 <= inventory.slotCount)
      {

        inventory.items.Add(this.item);
        this.item = null;

      }

    }
    else
    {

      if (inventory.items.Count > 0)
      {

        Item item = inventory.items[^1];
        inventory.items.RemoveAt(0);
        this.item = item;

        cookingProcess = CookItem();
        StartCoroutine(cookingProcess);

      }

    }

  }

}
