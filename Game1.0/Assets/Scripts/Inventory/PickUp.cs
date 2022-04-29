using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemInInventoty;

    private void Start()    
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        var e = Input.GetKey(KeyCode.E) ? 1 : 0;
        if (other.CompareTag("Player") && (e == 1))
        { 
            for (var i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemInInventoty, inventory.slots[i].transform);
                    Debug.Log(itemInInventoty);
                    Debug.Log(inventory.slots[0]);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }

    void Awake()
    {
        var countGun = GameObject.FindGameObjectsWithTag("Gun");
        var gunButton = GameObject.Find("GunButton");
        Debug.Log("Не зашел в If");
        Debug.Log("длина ган " + countGun.Length);
        if(countGun.Length > 2)
        {
            Debug.Log("УДАЛЯЮ in IF длина ган " + countGun.Length);
            Destroy(this.gameObject);
            Debug.Log("УДАЛЯЮ In if  " + this.gameObject);
        }
        Debug.Log(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }

    // void Awake1()
    // {
    //     var countGunButton = GameObject.FindGameObjectsWithTag("GunButton");
    //     Debug.Log("Не зашел в If");
    //     Debug.Log("длина ган батон " + countGunButton.Length);
    //     if(countGunButton.Length > 1)
    //     {
    //         Debug.Log("in IF длина ган батон " + countGunButton.Length);
    //         Destroy(this.gameObject);
    //         Debug.Log("In if  " + this.gameObject);
    //     }
    //     Debug.Log(this.gameObject);
    //     DontDestroyOnLoad(this.gameObject);
    // }
}
