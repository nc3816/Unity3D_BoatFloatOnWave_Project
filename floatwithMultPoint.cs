/***************
* floatWithMultPoint class
* This class animates the multiple points buoyanct
* Na Cui
**************/
using UnityEngine;
using System.Collections;

public class floatWithMultPoint : MonoBehaviour {
	public float waterLevel = 0.0f;
	public float floatHeight = 1.0f;
	public float bounceDamp = 0.05f;
	// set multiple points
	public Transform[] singlePoints;
	
	void  Start (){
		if (singlePoints[0] == null) {
			singlePoints[0].transform.position = transform.position;
		}
	}
	
	void  FixedUpdate (){
		for (int i = 0; i < singlePoints.Length; i++) {
			var actionPoint = singlePoints[i].transform.position;
			var forceFactor = (1f - ((actionPoint.y - waterLevel) / floatHeight)) / singlePoints.Length;
			
			if (forceFactor > 0f) {
				var uplift = -Physics.gravity * (forceFactor - GetComponent<Rigidbody> ().velocity.y * ((bounceDamp / singlePoints.Length) * Time.deltaTime));
				GetComponent<Rigidbody> ().AddForceAtPosition(uplift, actionPoint);
			}
		}
	}
}
