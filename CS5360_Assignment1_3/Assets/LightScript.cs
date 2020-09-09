using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {

    public GameScript game;

	// Use this for initialization
	void Start () {
	}

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && Input.GetButtonUp("GrabLight"))
        {
            game.Flush();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
