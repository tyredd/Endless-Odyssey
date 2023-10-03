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
        anim.SetFloat("Horizontal", horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(arrowPrefab, arrowSpawn.position, arrowSpawn.rotation);
        }
    }
}
