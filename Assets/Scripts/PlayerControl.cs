using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public GameObject arrowPrefab;
    public Transform arrowSpawn;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * verticalInput * speed * Time.deltaTime);
        
        //Animation Control
            //Forward
        if (horizontalInput > 0)
        {
            anim.SetBool("ForwardPress", true);
        }
        else if (horizontalInput == 0) {
            anim.SetBool("ForwardPress", false);
        }

            //Back
        if (horizontalInput < 0)
        {
            anim.SetBool("BackPress", true);
        }
        else if (horizontalInput == 0)
        {
            anim.SetBool("BackPress", false);
        }

            //Down
        if (verticalInput < 0)
        {
            anim.SetBool("DownPress", true);
        }
        else if (verticalInput == 0)
        {
            anim.SetBool("DownPress", false);
        }

            //Up
        if (verticalInput > 0)
        {
            anim.SetBool("UpPress", true);
        }
        else if (verticalInput == 0)
        {
            anim.SetBool("UpPress", false);
        }

        //Spawn arrows
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(arrowPrefab, arrowSpawn.position, arrowSpawn.rotation);
        }

        /*
        //Player Bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < lowerBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, lowerBound);
        }

        if (transform.position.z > topBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, topBound);
        }

        */
    }
}
