using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class move : MonoBehaviour
{

    public bool GameStart = true;
    public bool right = true;

    public float tapForce = 10;
    public float tiltSmooth = 5;
    public float speed = 3;



    Rigidbody2D rigidbody;
    Quaternion downRotation;
    Quaternion forwardRotation;
    private AudioSource _audioSource;

    public GameObject GameOver;

    void Start()
    {
        Time.timeScale = 0;
        rigidbody = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 35);

    }

    void OnCollisionEnter2D(Collision2D obj)
    {

        if (obj.gameObject.tag == "hell")
        {
            Destroy(this.gameObject);


            GameOver.SetActive(true);
            Time.timeScale = 0;
        }



        if (obj.gameObject.tag == "wall")
        {
            if (right == true)
            {
                right = false;
            }
            else if (right == false)
            {
                right = true;
            }
        }

      
    }


    public void touch()
    {
        transform.rotation = forwardRotation;
        rigidbody.velocity = Vector3.zero;
        rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
    }


    void Update()
    {

        if (GameStart && right)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                transform.rotation = forwardRotation;
                rigidbody.velocity = Vector3.zero;
                rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
            }
         
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);
        }

        if (GameStart && right == false)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                transform.rotation = forwardRotation;
                rigidbody.velocity = Vector3.zero;
                rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
            }

            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);
        }
       

    }
}
