using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour {

	public Light light;
	public bool ToggleLight;

	// Use this for initialization
	void Start () 
	{
		light = GetComponent<Light>();
		ToggleLight = false;
		light.color = new Color(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown("tab"))
        {
			if(!ToggleLight)
            {
				light.color = new Color(1, 1, 1);
			}
			else
            {
				light.color = new Color(0, 0, 0);
            }
			ToggleLight = !ToggleLight;
        }

	}
}
