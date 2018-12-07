using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class GameManager : MonoBehaviour {
    float interval = 0.0f;

    GameObject gameObject;
    List<GameObject> gameObjects = new List<GameObject>();

    public SpriteRenderer BGP;
    // Use this for initialization
    void Start ()
    {
        gameObject = GameObject.Find("StageBlack");
        // StageBlackの子オブジェクトを全て取得する
        foreach (Transform child in gameObject.transform)
        {
            gameObjects.Add(child.gameObject);
        }
        //
        change();
    }

    // Update is called once per frame
    void Update () {

        interval += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.A)/*&&interval>=5.0f*/)
        {
            if (BGP.color==Color.black) BGP.color=Color.white;
            else BGP.color = Color.black;
            change();
            interval = 0.0f;
        }
	}
    public void change()
    {
        foreach (GameObject obj in gameObjects)
        {
            Collider2D col2D = obj.GetComponent<Collider2D>();
            SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();
            if (BGP.color==Color.black)
            {
                if (spriteRenderer.color == Color.black)
                {
                    //spriteRenderer.color = Color.black;
                    col2D.enabled = false;
                }
                else
                {
                    //spriteRenderer.color = Color.white;
                    col2D.enabled = true;
                }
            }
            else
            {
                if (spriteRenderer.color == Color.white)
                {
                    //spriteRenderer.color = Color.black;
                    col2D.enabled = false;
                }
                else
                {
                    //spriteRenderer.color = Color.white;
                    col2D.enabled = true;
                }
            }
        }
    }
}
