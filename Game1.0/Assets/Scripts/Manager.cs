using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
   private Animator anim;
   public int levelToLoad;

   //private void Start()
   //{
   //    anim = GetComponent<Animator>();
   //}

   //public void FadeToLevel()
   //{
   //    anim.SetTrigger("fade");
   //}

   public void ChangeLevel()
   {
       SceneManager.LoadScene(levelToLoad);
   }

    public static void ExitGame()
    {
        Debug.Log("Игра закончилась");
        Application.Quit();
    }
}
