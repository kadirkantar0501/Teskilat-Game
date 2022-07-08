using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInventory : MonoBehaviour
{
    [SerializeField]
    GameObject inventoryScreen;

    [SerializeField]
    InputManager input;
    bool isInventoryOpen = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (input.onFoot.Inventory.triggered)
        {
            isInventoryOpen = !isInventoryOpen;
            print("NBR");
        }


        if (isInventoryOpen)
        {
            inventoryScreen.SetActive(true);
        }
        else
        {
            inventoryScreen.SetActive(false);
        }
    }
  

        

}
