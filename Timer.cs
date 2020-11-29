﻿using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public static float time;

	// Use this for initialization
	void Start () {
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(GoalArea.goal == false){
			time += Time.deltaTime;
		}
		int t = Mathf.FloorToInt(time);
		Text uiText = GetComponent<Text>();
		uiText.text = "Time :" + t.ToString();

	}
}
