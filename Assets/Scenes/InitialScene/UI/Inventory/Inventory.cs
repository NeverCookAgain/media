using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public int slotCount = 2;

    public GameObject inventoryButtonPrefab;
    public List<Item> items;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameObject.transform.childCount != slotCount) 
        {

            foreach (Transform childTransform in gameObject.transform) 
            {

                Destroy(childTransform.gameObject);

            }

            for (int i = 0; slotCount > i; i++) 
            {

                GameObject inventoryButton = Instantiate(inventoryButtonPrefab);
                inventoryButton.name = "Item" + i;
                inventoryButton.transform.SetParent(gameObject.transform);

            }

        }

        for (int i = 0; gameObject.transform.childCount > i; i++)
        {

            Transform childTransform = gameObject.transform.GetChild(i);
            InventoryButton button = childTransform.GetComponent<InventoryButton>();
            if (items.Count - 1 < i) 
            {
                
                button.SetItem(null);

            } 
            else if (button.GetItem() != items[i])
            {

                button.SetItem(items[i]);

            }

        }

    }

}
