﻿using UnityEngine;
using System.Collections;

public class FlipperRotation : MonoBehaviour {

	[SerializeField]private GameObject[] flippers;

	public void Rotate(bool left, bool right) {
		if(left) {
			flippers[0].transform.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,1000), ForceMode.Acceleration);
		}

		if(right) {
			flippers[1].transform.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,1000), ForceMode.Acceleration);
		}
	}
}