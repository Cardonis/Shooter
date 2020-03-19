using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullets : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnnemiBullet") || collision.CompareTag("PlayerBullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}
