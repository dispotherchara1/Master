using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Animator animator;
    GameObject Pc;
    Vector2 playvec;
    public float Speed = 0.05f;
    bool move = false;
    // Use this for initialization
    void Start()
    {
        Pc = this.gameObject;
        playvec.x = Pc.transform.position.x;
        animator = this.gameObject.GetComponent<Animator>();
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
            gameObject.transform.localScale = new Vector3(5, 5, 1);
            playvec.y = Pc.transform.position.y;
            Pc.transform.position = new Vector2(playvec.x -= Speed,playvec.y+=0);
            animator.SetBool("Walk", true);
            move = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.localScale=new Vector3(-5, 5, 1);
            playvec.y = Pc.transform.position.y;
            Pc.transform.position = new Vector2(playvec.x += Speed, playvec.y+=0);
            animator.SetBool("Walk", true);
            move = true;
        }
        if (!Input.anyKey) { animator.SetBool("Walk", false); move = false; }
    }
    

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Xbox")
        {
           // if(move==true)
        }
    }
}
