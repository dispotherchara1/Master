using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brock : MonoBehaviour {

    SpriteRenderer MainSpriteRenderer;
    Collider2D col;

    public Sprite WhiteSprite;
    public Sprite BrackSprite;

    void Start()
    {
        // このobjectのSpriteRenderer,Colliderを取得
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        col = gameObject.GetComponent<Collider2D>();
    }

    public void Blackor(bool a)
    {
        if (a == true)
        {
            MainSpriteRenderer.sprite = BrackSprite;
            col.enabled = true;
        }
    }
    public void Whitecor(bool a)
    {
        if (a == false)
        {
            MainSpriteRenderer.sprite = WhiteSprite;
            col.enabled = false;
        }
    }
}
