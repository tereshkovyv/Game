using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInterface : MonoBehaviour
{
    public void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
