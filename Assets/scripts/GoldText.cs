using UnityEngine;
using System;
using System.Collections;

public class GoldText : MonoBehaviour {

    public double gold = 500;

	// Update is called once per frame
	void Update () {
        TextMesh tm;
        tm = GetComponent<TextMesh>();
        tm.text = Convert.ToString(gold);
    }



}
