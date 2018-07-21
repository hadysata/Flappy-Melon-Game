using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D obj)
    {

        if (obj.gameObject.tag == "hell")
        {
            Destroy(this.gameObject);
        }

        if (obj.gameObject.tag == "Player")
        {

            control.score = control.score + 1;
            Destroy(this.gameObject);

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
