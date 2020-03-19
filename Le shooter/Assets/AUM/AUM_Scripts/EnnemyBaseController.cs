using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBaseController : Ennemy
{
    public float speed;
    public GameObject projectile;
    public LayerMask layerMask;
    public Rigidbody2D rB2D;

    Vector2 direction;

    public float distanceLeft;
    public float distanceRight;

    public enum Direction {Right, Left, Up, Down }

    public Direction currentDirection;

    bool changed = false;

    // Start is called before the first frame update
    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    private void FixedUpdate()
    {
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.right, Mathf.Infinity, layerMask);
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, -Vector2.right, Mathf.Infinity, layerMask);

        if (hitLeft.distance < distanceLeft && changed == false)
        {
            StartCoroutine(ChangeDirection(Direction.Down, Direction.Right));
        }

        if(hitRight.distance < distanceRight && changed == false)
        {
            StartCoroutine(ChangeDirection(Direction.Down, Direction.Left));
        }

        switch(currentDirection)
        {
            case Direction.Left:
                direction = Vector2.left;
                    break;
            case Direction.Right:
                direction = Vector2.right;
                break;
            case Direction.Up:
                direction = Vector2.up;
                break;
            case Direction.Down:
                direction = Vector2.down;
                break;
        }

        rB2D.velocity = direction.normalized * speed;

    }

    IEnumerator ChangeDirection(Direction firstDir, Direction endDir)
    {
        changed = true;

        currentDirection = firstDir;

        yield return new WaitForSeconds(0.5f);

        currentDirection = endDir;

        yield return new WaitForSeconds(0.1f);

        changed = false;
    }

    public void Die()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Player_Movement>().TakeDamage(1);
        }
    }
}
