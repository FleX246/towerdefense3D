using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    //Array fuer Monster
    public GameObject[] MonsterPrefs;

    // Spawn Delay in seconds
    public float interval = 3;

    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("SpawnNext", interval, interval);
	}
	
    void SpawnNext()
    {
        Instantiate(MonsterPrefs[Random.Range(0, MonsterPrefs.Length)], transform.position, Quaternion.identity);
    }

}
