using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokemonshokku : MonoBehaviour {

    SpriteRenderer Shock;
    bool shocker=false;
	// Use this for initialization
	void Start () {
        Shock = this.gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
            shocker=true;
        if (Input.GetKeyDown(KeyCode.B))
            shocker=false;
	}

    void onred()
    {
        if (shocker == true && Shock.color != Color.red) Shock.color = Color.red;
        Invoke("onblue", 0.1f);
    }

    void onblue()
    {
        if (shocker == true && Shock.color != Color.blue) Shock.color = Color.blue;
        Invoke("ongreen", 0.1f);
    }

    void ongreen()
    {
        if (shocker == true && Shock.color != Color.green) Shock.color = Color.green;
        Invoke("onred", 0.1f);
    }

}
