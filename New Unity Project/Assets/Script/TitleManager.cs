using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour {

    public Canvas PushButton;
    bool Title = true;
    private GameObject textObject; //点滅させたい文字
    int StageSelect=0;
    private float nextTime;
    public  float interval = 0.3f; //点滅周期
    string conmai ="";


    void Start () {
        textObject = GameObject.Find("text");
        nextTime = Time.time;
    }

    void Update() {
        //文字点滅
        if (Title == true) {
            //何か押せば点滅は終わる
            if (Input.anyKeyDown){ interval = 0.1f; Invoke("GoSelect", 1); }
            //一定時間ごとに点滅
            if (Time.time > nextTime && PushButton.enabled == true)
            {
                //選択したGameObjectよりα値を取る
                float alpha = textObject.GetComponent<CanvasRenderer>().GetAlpha();
                //α値が1(不透明)の時
                if (alpha == 1.0f)//透明に
                    textObject.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                //そうでないとき
                else//不透明に
                    textObject.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
                //3秒後にまたこれを繰り返す
                nextTime += interval;
            }
        }
        else { }


    }

    /// <summary>
    /// SelectSceneに移行します
    /// </summary>
    void GoSelect()
    {
        textObject.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
        PushButton.enabled = false;     Title = false;
    }
}