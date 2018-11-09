using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    GameObject Pc;
    Vector2 playvec;
    public float Speed = 0.05f;
    // Use this for initialization
    void Start()
    {
        Pc = this.gameObject;
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
            Pc.transform.position = new Vector2(Pc.transform.position.x + (InputDirection.x/20), Pc.transform.position.y+0/*InputDirection.y*/);
        }
        //else { Pc.transform.position = new Vector2(0, 0); }
        //Debug.Log(InputDirection.x + " , " + InputDirection.y);
    }
}
