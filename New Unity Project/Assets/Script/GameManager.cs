﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour {


    GameObject gameObject;
    List<GameObject> gameObjects = new List<GameObject>();

    // Use this for initialization
    void Start ()
    {
        gameObject = GameObject.Find("StageBlack");
        // StageBlackの子オブジェクトを全て取得する
        foreach (Transform child in gameObject.transform)
        {
            gameObjects.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            change();
        }
	}
    public void change()
    {
        foreach (GameObject obj in gameObjects)
        {
            Collider2D col2D = obj.GetComponent<Collider2D>();
            SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();
            if (spriteRenderer.color == Color.white)
            {
                spriteRenderer.color = Color.black;
                col2D.enabled = true;
            }
            else
            {
                spriteRenderer.color = Color.white;
                col2D.enabled = false;
            }
        }
    }
}
