using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    [HideInInspector] public float launchSpeed;
    public float bulletTypeSpeed;
    public float launchCD;
    Rigidbody2D rB2D;
    Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
        movement = new Vector2(0, bulletTypeSpeed + launchSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        rB2D.velocity = movement;
    }


}
