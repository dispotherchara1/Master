using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriateStage : MonoBehaviour {

    GameObject Player;
    Vector2 playvec;
    public float Speed = 0.05f;
	// Use this for initialization
	void Start () {
        Player = this.gameObject;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        //水平入力と垂直入力から入力方向を調べる.
        Vector2 InputDirection;
        InputDirection.x = Input.GetAxis("Horizontal")/20;
        InputDirection.y = Input.GetAxis("Vertical")/20;
        //入力が0でなければ、重力方向を変更する.
        if (InputDirection.magnitude > 0)
        {
            playvec = new Vector2(Player.transform.position.x, Player.transform.position.y);
            //←
            Player.transform.position = new Vector2(playvec.x+InputDirection.x,playvec.y+InputDirection.y);
        }
        
        //else { Player.transform.position = new Vector2(0, 0); }
        if (Input.GetKey(KeyCode.Z))
        {
        Vector3 axis = new Vector3(0f, 0f, 1f); // 回転軸
        float angle = 360f * Time.deltaTime; // 回転の角度
        Quaternion q = Quaternion.AngleAxis(angle, axis); // 軸axisの周りにangle回転させるクォータニオン

        this.transform.rotation = q * this.transform.rotation; // クォータニオンで回転させる
        }
    }
}
