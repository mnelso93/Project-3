using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour {
	[VectorScaleAttribute(0.1F, 5.0F)]
	public float scale = 1;

	[ColorLineAttribute(100f, 100f, 100f)]
	[SpriteShowAttribute(200, 200)]
	public Sprite mySprite;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
