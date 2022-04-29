// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class LockDeletePrefabs : MonoBehaviour
// {
//     void Awake()
//     {
//         var objec = GameObject.FindGameObjectsWithTag("Gun");
//         if(objec.Length > 1)
//         {
//             Debug.Log(objec.Length);
//             Debug.Log("Dest if >");
//             Destroy(this.gameObject);
//         }
//         Debug.Log("DontDestr");
//         DontDestroyOnLoad(this.gameObject);
//     }
// }
