using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Animator animator;
    GameObject Pc;
    Vector2 playvec;
    public float Speed = 0.05f;
    bool move = false;
    Vector2 start;
    // Use this for initialization
    void Start()
    {
        Pc = this.gameObject;
        animator = this.gameObject.GetComponent<Animator>();
        start = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);//自分が初めてぽｐした場所を保存
    }

    // Update is called once per frame
    void Update()
    {
        //水平入力と垂直入力から入力方向を調べる.
        Vector2 InputDirection;
        InputDirection.x = Input.GetAxis("Horizontal");
        InputDirection.y = Input.GetAxis("Vertical");
        //入力が0でなければ動く.
        if (InputDirection.magnitude > 0)
        {
            Pc.transform.position = new Vector2(playvec.x + (InputDirection.x/20), playvec.y+0/*InputDirection.y*/);
            animator.SetBool("Walk", true);
            move = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            walk(-1, -1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            walk(1, 1);
        }
        if (!Input.anyKey) { animator.SetBool("Walk", false); move = false; }

        if (gameObject.transform.position.y <= -10) Restart();
    }
    
    void walk(int a,int b)
    {
            playvec.x = Pc.transform.position.x;
            gameObject.transform.localScale=new Vector3(-5*a, 5, 1);
            playvec.y = Pc.transform.position.y;
            Pc.transform.position = new Vector2(playvec.x += Speed*b, playvec.y+=0);
            animator.SetBool("Walk", true);
            move = true;
    }

    void Restart()
    {
        gameObject.transform.position =new Vector2 (start.x,start.y+3);
    } 

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "save")
        {
            start = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);//中間地点
        }
    }
    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.transform.tag == "Xbox")
    //    {
    //       // if(move==true)
    //    }
    //}
}
/* アンドロイド弾丸の眼差しで 今朝アンダマンの海を越え
 * 意思に母の心ねは
 * She was made in Malaysia
 * 
 * 鉄を焼く熱帯びて 祈る姿可憐と
 * 寝た子は皆焦がれ死ぬ
 * She was made in Malaysia
 * 
 * 日は来たりと キミよ今アトムなる
 * Migthty Migthty Mighty Mighty
 * Here comes sister Archetype Engine
 * Here comes sister Archetype Engine
 */