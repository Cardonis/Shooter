using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    Vector2 movement;
    Rigidbody2D rB2D;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Move();

    }

    void Move()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (movement.magnitude > 0)
        {
            rB2D.velocity = movement * speed; 
        }
        else
        {
            rB2D.velocity = new Vector2(0, 0);
        }

    }
}
