using UnityEngine;
using System.Collections;
using Vuforia;
public class VBscript : MonoBehaviour, IVirtualButtonEventHandler {

    GameObject VButtonObject;
	// Use this for initialization
	void Start () {
        VButtonObject = GameObject.Find("RotateButton");
        VButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler (this);
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("button pressed");
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("button released");
    }
}
