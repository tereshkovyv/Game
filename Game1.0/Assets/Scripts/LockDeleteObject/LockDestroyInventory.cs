using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDestroyInventory : MonoBehaviour
{
    void Awake()
    {
        var playerInterFace = GameObject.FindGameObjectsWithTag("inventory");
        if(playerInterFace.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
