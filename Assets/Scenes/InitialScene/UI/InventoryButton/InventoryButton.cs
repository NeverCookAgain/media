using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{

    public Item item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Image imageComponent = gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
        imageComponent.sprite = item?.Sprite;
        imageComponent.color = new Color32(255, 255, 255, (byte) (item != null ? 255 : 0));

    }

    // Activates when the player presses the button on the screen.
    public void Activate() {

        item?.Activate();

    }
}
