using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    [HideInInspector] public float launchSpeed;
    public float bulletTypeSpeed;
    public float launchCD;
    public Rigidbody2D rB2D;
    Vector2 movement;

    public int bulletDamage;

    public float direction;
    
    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector2(0, (bulletTypeSpeed + launchSpeed) * direction);
    }

    // Update is called once per frame
    void Update()
    {
        rB2D.velocity = movement;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ennemy")
        {
            collision.GetComponent<Ennemy>().TakeDamage(bulletDamage);

            Destroy(gameObject);
        }

        if (collision.tag == "Player")
        {
            collision.GetComponent<Player_Movement>().TakeDamage(bulletDamage);

            Destroy(gameObject);
        }
    }
}
