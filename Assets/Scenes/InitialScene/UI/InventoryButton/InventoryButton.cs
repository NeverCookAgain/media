using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{

  private Item item;

  // Activates when the player presses the button on the screen.
  public void Activate()
  {

    if (item)
    {

      item?.Activate();

    }


  }

  public Item GetItem()
  {

    return item;

  }

  public void SetItem(Item item)
  {

    this.item = item;

    Image imageComponent = gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
    imageComponent.sprite = item != null ? item.Sprite : null;
    imageComponent.color = item != null ? item.colors[item.GetBurnLevel()] : new Color32(255, 255, 255, 0);

  }

}
