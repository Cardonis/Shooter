using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnnemi : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ennemy"))
        {
            if(collision.GetComponent<Ennemy>().isActive == false)
            {

                collision.GetComponent<Ennemy>().isActive = true;
            }
        }
    }
}
