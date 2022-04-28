using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject inventory;
    private bool inventoryOpen;

    private void Start()
    {
        inventoryOpen = true;
    }

    public void Chest()
    {
        //var space = Input.GetKey(KeyCode.Space) ? 1 : 0;
        if (inventoryOpen == false)
        {
            inventoryOpen = true;
            inventory.SetActive(true);
        }
        else if (inventoryOpen == true) 
        {
            inventoryOpen = false;
            inventory.SetActive(false);
        }
    }
}
