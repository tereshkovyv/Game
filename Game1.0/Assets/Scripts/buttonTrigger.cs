using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonTrigger : MonoBehaviour
{
    public Animator anim;
    public GameObject frame;
    public GameObject[] otherFrames;
    public int levelToLoad;
    public float lastX;
    public float lastY;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("isTriggered");
            frame.SetActive(true);
            foreach (GameObject frame in otherFrames)
            {
                frame.SetActive(false);
            }   
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("isTriggered");
        }
    }

    public void loadNextLevel()
    {
        if (levelToLoad == 1)
        {
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
