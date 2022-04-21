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

    private Vector3 mousePos;

    //Hero hero = new Hero();
    [SerializeField]
    private static float acceleration = 0.5f;
    internal static Rigidbody2D hero;
    private static int livesHero = 10;
    //public VectorValue pos;
    //private int playerRotation = 1;
    //public static Transform heroObject = GameObject.Find("Hero").transform;

    //private Animator anim;

    //public int LivesHero { get => livesHero; set => livesHero = value; }

    void Start()
    {
        //anim = GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(this);
        hero = GetComponent<Rigidbody2D>();
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void Update()
    {
        //MoveHero();
      

        var w = Input.GetKey(KeyCode.W) ? 1 : 0;
        var s = Input.GetKey(KeyCode.S) ? 1 : 0;
        var a = Input.GetKey(KeyCode.A) ? 1 : 0;
        var d = Input.GetKey(KeyCode.D) ? 1 : 0;
        var shift = Input.GetKey(KeyCode.LeftShift) ? 1 : 0;
        // var space = Input.GetKey(KeyCode.Space) ? 1 : 0;

        if (shift == 1)
        {
            shift = 5;
        }
        else
        {
            shift = 1;
        }
        // if(space == 1)
        // {
        //     Inventory.Chest();
        // }

        var movementVector = new Vector2(d - a, w - s);
        hero.velocity = movementVector * acceleration * shift;

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

    public static void TakeDamadge(double widthMonster, Transform monster)
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

    // public static void GetMouseClick()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         Debug.Log("�����");
    //     }
    // }
}

//����������� �� �����
//void OnMouseDrag()
//{
//    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//    mousePos.x = mousePos.x > 332f ? 332f : mousePos.x;
//    mousePos.x = mousePos.x < -332f ? -332f : mousePos.x;
//    //player.up = Camera.main.ScreenToWorldPoint (Input.mousePosition.x);
//    hero.position = Vector2.MoveTowards(hero.position,
//        new Vector2(mousePos.x, hero.position.y),
//        acceleration * Time.deltaTime);


//}

// ������ ������� ���������� �� ����� 
//private Vector3 TPosition;
//private bool isMoving = false;
//� ������ �����
//transform.position = pos.initialValue;
//������ ������ 
//void TriggerPosition()
//{

//    TPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//    TPosition.z = transform.position.z;

//    isMoving = true;
//}

//void ItsMove()
//{
//    transform.rotation = Quaternion.LookRotation(Vector3.forward, TPosition);
//    transform.position = Vector3.MoveTowards(transform.position, TPosition, acceleration * Time.deltaTime);

//    if (transform.position == TPosition)
//    {
//        isMoving = false;
//    }
//}
// ����� ������
//if (Input.GetMouseButton(0))
//{
//    TriggerPosition();
//}

//if (isMoving)
//{
//    ItsMove();
//}

