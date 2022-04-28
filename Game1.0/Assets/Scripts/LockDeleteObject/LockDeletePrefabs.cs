using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDeletePrefabs : MonoBehaviour
{
    //public GameObject gameObject;
    void Awake()
    {
        var gameObject = GameObject.FindGameObjectsWithTag("Gun");

        if(gameObject.Length > 2)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
