﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        Application.LoadLevel(0);
    }
}
