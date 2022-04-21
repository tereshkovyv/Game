using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Monster2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var monster2 = GameObject.Find("BookOfDeath2").transform;
        var widthMonster = 0.75;
        var hero = GameObject.Find("Hero").transform;

        Hero.TakeDamadge(widthMonster, monster2);
    }
}
