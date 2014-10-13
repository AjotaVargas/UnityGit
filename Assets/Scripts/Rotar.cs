using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour {

	public Vector3 rot;
	
	void Update () {
		transform.Rotate ( rot ); //rama1
	}
}
