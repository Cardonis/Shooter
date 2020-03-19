using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTheEnnemy : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ennemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
