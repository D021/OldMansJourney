﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeOutUIOnTap : FadeOutUI 
{

	// Update is called once per frame
	void Update () 
	{
		base.Update ();

		if (faded)
			return;
		
		if (Input.GetMouseButtonUp (0)) 
		{
			if(mouseDelta.magnitude < 0.01)
			{
				StartCoroutine(fadeOut());
			}
		}
	}
}
