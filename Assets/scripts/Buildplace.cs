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
            if(GameObject.Find("Gold").GetComponent<GoldText>().gold >= 100)
            {
                GameObject g = (GameObject)Instantiate(towerPrefab);
                g.transform.position = transform.position + Vector3.up;
                bebaut = true;
                GameObject.Find("Gold").GetComponent<GoldText>().gold -= 100;
            }

        }
    }


}
