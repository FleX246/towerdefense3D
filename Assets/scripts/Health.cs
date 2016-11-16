using UnityEngine;
using System.Windows.Forms;
using System;
using System.Collections;

public class Health : MonoBehaviour {
    // The TextMesh Component
    TextMesh tm;

    // Use this for initialization
    void start () {
        tm = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update () {
        // Face the Camera
        transform.forward = Camera.main.transform.forward;
    }

    public int current() {
        return tm.text.Length;
    }

    // Decrease the current Health by removing one '-'
    public void decrease() {
        string msg = Convert.ToString(tm.text.Length);
        MessageBox.Show(msg + "test");
        if (current() > 1)
            tm.text = tm.text.Remove(tm.text.Length - 1);
        else
            Destroy(transform.parent.gameObject);
    }


}
