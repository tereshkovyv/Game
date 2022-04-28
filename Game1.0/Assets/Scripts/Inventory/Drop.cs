using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject item;

    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(Hero.hero.position.x - 0.2f, Hero.hero.position.y);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
