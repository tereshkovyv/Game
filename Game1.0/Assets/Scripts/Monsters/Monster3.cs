using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Monster3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var monster3 = GameObject.Find("BookOfDeath3").transform;
        var widthMonster = 0.75;
        var hero = GameObject.Find("Hero").transform;

        Hero.TakeDamage(widthMonster, monster3);
    }
}
