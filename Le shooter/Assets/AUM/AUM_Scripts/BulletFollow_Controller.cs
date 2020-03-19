using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFollow_Controller : MonoBehaviour
{
    public Transform target;

    public float rotateSpeed;

    public float speed;

    Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb2D.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, -transform.up).z;

        rb2D.angularVelocity = -rotateAmount * rotateSpeed;

        rb2D.velocity = transform.up * speed;
    }
}
