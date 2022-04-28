using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Hero : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public int numOfHearts;

    //private Vector3 mousePos;

    [SerializeField]
    private static float acceleration = 0.5f;
    internal static Rigidbody2D hero;
    private static int livesHero = 10;

    private Animator anim;

    //public int LivesHero { get => livesHero; set => livesHero = value; }

    void Start()
    {
        anim = GetComponent<Animator>();
        hero = GetComponent<Rigidbody2D>();
        // Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }   

    void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Player");
        if(obj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        MoveNext();

        //var space = Input.GetKey(KeyCode.Space) ? 1 : 0;
        // if(space == 1)
        // {
        //     Inventory.Start();
        // }
        
        if (livesHero > numOfHearts)
        {
            livesHero = numOfHearts;
        }
        for (var i = 0; i < hearts.Length; i++)
        {
            if (i < Mathf.RoundToInt(livesHero))
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        var esc = Input.GetKey(KeyCode.Escape) ? 1 : 0;
        
        if (esc != 0)
        {
            Manager.ExitGame();
        }
    }

    public static void TakeDamage(double widthMonster, Transform monster)
    {
        if ((Math.Abs(hero.position.x - monster.position.x) <= widthMonster) && monster != null)
        {
            Destroy(monster.gameObject);
            livesHero -= 4;

            if(livesHero <= 0)
            {
                Debug.Log(livesHero);
                Destroy(hero.gameObject);
                Manager.ExitGame();
            }
        }
    }

    private void MoveNext()
    {
        var w = Input.GetKey(KeyCode.W) ? 1 : 0;
        var s = Input.GetKey(KeyCode.S) ? 1 : 0;
        var a = Input.GetKey(KeyCode.A) ? 1 : 0;
        var d = Input.GetKey(KeyCode.D) ? 1 : 0;
        var shift = Input.GetKey(KeyCode.LeftShift) ? 1 : 0;

        GetAnimHero(w,s,a,d);
        
        if (shift == 1)
        {
            shift = 5;
        }
        else
        {
            shift = 1;
        }

        var movementVector = new Vector2(d - a, w - s);
        hero.velocity = movementVector * acceleration * shift;
    }

    private void GetAnimHero(int w, int s, int a, int d)
    {
        var heroLookRight = GetComponent<SpriteRenderer>();

        if(d == 1)
        {
            heroLookRight.flipX = false;
            anim.SetBool("IsRunning", true);
        }
        else if(a == 1)
        {
            heroLookRight.flipX = true;
            anim.SetBool("IsRunning", true);
        }
        else if (w == 1)
        {
            anim.SetBool("IsMoveFront", true);
        }
        else
        {
            anim.SetBool("IsMoveFront", false);
            anim.SetBool("IsRunning", false);
        }
    }

    // public static void GetMouseClick()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         Debug.Log("�����");
    //     }
    // }
}