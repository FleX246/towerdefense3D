using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Pause : MonoBehaviour
{
    public bool pause;

    // Use this for initialization
    void Start()
    {
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void onPause()
    {
        pause = !pause;
        if (!pause)
        {
            Time.timeScale = 1;
        }

        else if (pause)
        {
            Time.timeScale = 0;
        }
    }
}