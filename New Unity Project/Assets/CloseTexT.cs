using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseTexT : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            text.enabled = false;
        }
	}
}
