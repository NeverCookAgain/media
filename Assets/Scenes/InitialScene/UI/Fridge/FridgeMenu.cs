using UnityEngine;
using UnityEngine.UI;

public class FridgeMenu : MonoBehaviour
{
    public GameObject fridgeBG;
    public Button xFridgeButton;
    public GameObject[] fridgeItems;

    private bool isOpen = false;

    void Awake()
    {
        fridgeBG.SetActive(false);
        xFridgeButton.gameObject.SetActive(false);
        SetItemsActive(false);
    }

    void Start()
    {
        // closes fridge by pressing the x button shown in menu
        xFridgeButton.onClick.AddListener(CloseFridge);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleFridge();
        }
    }

    void ToggleFridge()
    {
        isOpen = !isOpen;
        fridgeBG.SetActive(isOpen);
        xFridgeButton.gameObject.SetActive(isOpen);
        SetItemsActive(isOpen);
    }

   public void CloseFridge()
{
    Debug.Log("CloseFridge() clicked!");

    isOpen = false;
    fridgeBG.SetActive(false);
    xFridgeButton.gameObject.SetActive(false);
    SetItemsActive(false);
}


    void SetItemsActive(bool active)
    {
        foreach (GameObject item in fridgeItems)
        {
            item.SetActive(active);
        }
    }
}
