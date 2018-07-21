using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject Character;
    public Vector3 spawnLocation = new Vector3(0, 2, 0);
    public float spawnTime = 2f;
    public float y = 6.5f;

	// Use this for initialization
	void Start () {
        Physics2D.IgnoreLayerCollision(8, 9);
        Physics2D.IgnoreLayerCollision(8, 10);
        Physics2D.IgnoreLayerCollision(9, 10);
        InvokeRepeating("sp", spawnTime, spawnTime);
	}

    void sp()
    {
        spawnLocation = new Vector3(Random.Range(-2.04f, 2.96f), y, 0);
        GameObject SpawnLocation = (GameObject)Instantiate(Character, spawnLocation, Quaternion.identity);
        flip.speed += 0.1f;
    }

  
	
	
	// Update is called once per frame
	void Update () {

       // StartCoroutine(spawn());
	}
}
