using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class GameManager : MonoBehaviour {
    float interval = 0.0f;

    GameObject gameObject;
    List<GameObject> gameObjects = new List<GameObject>();

    public bool brack = true;

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
    }

    // Update is called once per frame
    void Update () {

        interval += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.A)/*&&interval>=5.0f*/)
        {
            if (brack != true) brack = true;
            else brack = false;
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
            if (brack == true)
            {
                if (spriteRenderer.color == Color.white)
                {
                    //spriteRenderer.color = Color.black;
                    col2D.enabled = true;
                }
                else
                {
                    //spriteRenderer.color = Color.white;
                    col2D.enabled = false;
                }
            }
            else
            {
                if (spriteRenderer.color == Color.black)
                {
                    //spriteRenderer.color = Color.black;
                    col2D.enabled = true;
                }
                else
                {
                    //spriteRenderer.color = Color.white;
                    col2D.enabled = false;
                }
            }
        }
    }
}
