using UnityEngine;
using System.Collections;

public class Buildplace : MonoBehaviour {

    // The Tower that should be built
    public GameObject towerPrefab;

    bool bebaut=false;

    void OnMouseUpAsButton()
    {
        // Build Tower above Buildplace
        if(!bebaut)
        {
            GameObject g = (GameObject)Instantiate(towerPrefab);
            g.transform.position = transform.position + Vector3.up;
            bebaut = true;
        }
    }


}
