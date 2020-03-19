using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public int life;

    public bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    public void TakeDamage(int damage)
    {
        life -= damage;

        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
