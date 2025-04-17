using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeMenu : MonoBehaviour
{
    public GameObject FridgeSprite;

    void Start()
    {
        FridgeSprite.SetActive(false); 
    }

    void Update()
{
    if (Input.GetKeyDown(KeyCode.E))
    {
        Debug.Log("E was pressed!");
        FridgeSprite.SetActive(!FridgeSprite.activeSelf);
    }
}

}


