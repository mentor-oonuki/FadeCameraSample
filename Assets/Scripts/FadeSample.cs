using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
using DG.Tweening;

public class FadeSample : MonoBehaviour {

	private float Intensity;
	private ScreenOverlay screenOverlay;


	void Start()
	{
		screenOverlay = gameObject.GetComponent<ScreenOverlay>();
	}


	void Update () {
		
	}
}
