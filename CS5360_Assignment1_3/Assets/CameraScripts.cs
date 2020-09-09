using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class CameraScripts : MonoBehaviour {
    public VRMirror mirror;
    public bool positionTracking = true;
    public bool rotationTracking = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Tab)){
            this.gameObject.transform.localPosition = new Vector3(0, 0, 0);
            this.gameObject.transform.localRotation = Quaternion.identity;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.gameObject.transform.localPosition = new Vector3(0, 0, 0);
            this.gameObject.transform.Rotate(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            mirror.ToggleMirror();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            rotationTracking = !rotationTracking;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            positionTracking = !positionTracking;
        }

        if (!positionTracking)
        {
            transform.position = -InputTracking.GetLocalPosition(XRNode.CenterEye);
        }
        if (!rotationTracking)
        {
            transform.rotation = Quaternion.Inverse(InputTracking.GetLocalRotation(XRNode.CenterEye));
        }
    }
}
