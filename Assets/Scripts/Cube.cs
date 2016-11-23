using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Cube : MonoBehaviour {

	public GameObject objCube;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (objCube != null) {
			objCube.transform.Rotate (0, 1, 0);
		}
	}
}
