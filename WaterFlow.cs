/***************
* WaterFlow class
* This class animates x-y plain offsetting
* Na Cui
**************/
using UnityEngine;
using System.Collections;


public class WaterFlow : MonoBehaviour {
	// variable for X and Z speed
	public float m_SpeedX = 0.1f;
	public float m_SpeedZ = -0.1f;
	
	void Update () {
		//update the X and Z speed by Time.time
		float newOffsetX = Time.time * m_SpeedX;
		float newOffsetZ = Time.time * m_SpeedZ;
		
		// Check if there is renderer component
		if (this.GetComponent<Renderer>())
		{
			// Update the texture offset
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2(newOffsetU, newOffsetV);
		}
	}
}