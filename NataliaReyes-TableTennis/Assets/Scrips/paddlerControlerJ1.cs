using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlerControlerJ1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Right

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.back * .01f);
        }

        // Left

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.forward * .01f);
        }

        // Up

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * .01f);
        }

        // Down

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down * .01f);
        }
    }
}
