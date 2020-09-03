using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {

    public GameScript game;

	// Use this for initialization
	void Start () {
        game = GetComponentInParent<GameScript>();
	}

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && Input.GetButtonDown("GrabLight"))
        {
            game.Flush();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
