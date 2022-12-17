using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private bool isDead; 
    [SerializeField] private float upForce = 350f;
    void Start()
    {
        this.playerRb = GetComponent<Rigidbody2D>();
        this.isDead = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            this.playerRb.velocity = Vector2.zero;
            this.playerRb.AddForce(Vector2.up * upForce);
        }
    }

    public void OnCollisionEnter2D()
    {
        this.isDead = true;   
    }
}
