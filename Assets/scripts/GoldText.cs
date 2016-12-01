using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class GoldText : MonoBehaviour {

    public double gold = 500;

	// Update is called once per frame
	void Update () {
        Text t;
        t = GetComponent<Text>();
        t.text = "Coins: " + Convert.ToString(gold);
    }



}
