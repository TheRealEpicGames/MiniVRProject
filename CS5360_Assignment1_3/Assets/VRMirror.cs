using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMirror : MonoBehaviour {
    public bool isMirroring;
    public GameObject player;
    public Vector3 initialPlayerPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isMirroring)
        {
            this.transform.localPosition = new Vector3(player.transform.localPosition[0], player.transform.localPosition[1], -player.transform.localPosition[2]) - initialPlayerPos;
            this.transform.localRotation = Quaternion.Inverse(player.transform.localRotation);
        }
	}
    
    public void ToggleMirror()
    {
        if (isMirroring == false)
        {
            //initialPlayerPos = player.transform.localPosition;
            initialPlayerPos = new Vector3(0, 0, 0);
        }
        isMirroring = !isMirroring;
    }
}
