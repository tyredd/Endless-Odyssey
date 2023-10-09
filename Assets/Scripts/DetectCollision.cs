using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private Animator animator;
    public string animationTrigger = "Hit";
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        else if (other.gameObject.tag == "Enemy")
        {
            gameManager.AddScore(10);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}