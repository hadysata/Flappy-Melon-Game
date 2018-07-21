using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour {
  static  public float speed = 0.3f;

    public bool right = true;
	// Use this for initialization
	void Start () {
	}


    void OnCollisionEnter2D(Collision2D obj)
    {

        if (obj.gameObject.tag == "hell")
        {
            Destroy(this.gameObject);

        }

        if (obj.gameObject.tag == "wall")
        {
            if (right == true)
            {
                right = false;
            }
            else
            {
                right = true;
            }
        }

    }
      
    
	
	// Update is called once per frame
	void Update () {


        if (right == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        this.transform.Rotate(Vector3.forward * -90 * speed * Time.deltaTime);

	}
}
