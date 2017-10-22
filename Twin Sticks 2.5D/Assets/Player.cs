using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("H: " + CrossPlatformInputManager.GetAxis("Horizontal")); // The "H: " + labels the front of what is logged to the console. So I could anything instead of H:.
        Debug.Log("V: " + CrossPlatformInputManager.GetAxis("Vertical"));
       // Debug.Log(CrossPlatformInputManager.GetAxis("Mouse Y"));
       // Debug.Log(CrossPlatformInputManager.GetAxis("Mouse X"));
       // Debug.Log(CrossPlatformInputManager.GetButtonDown("Fire1"));
       // Debug.Log(CrossPlatformInputManager.GetButtonDown("Jump"));
    }
}
