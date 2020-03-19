using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyFollowController : Ennemy
{
    public float speed;
    public GameObject projectile;
    public LayerMask layerMask;
    public Rigidbody2D rB2D;

    Vector2 direction;

    bool changed = false;

    // Start is called before the first frame update
    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

        rB2D.velocity = Vector2.down.normalized * speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Player_Movement>().TakeDamage(1);
        }
    }
}
