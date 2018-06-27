using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotateScript : MonoBehaviour {

    //controls rotation speed
    public float speed = 1;

	// Use this for initialization
	void Start () {
        Debug.Log("test");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(speed, 0, 0);
	}
}
