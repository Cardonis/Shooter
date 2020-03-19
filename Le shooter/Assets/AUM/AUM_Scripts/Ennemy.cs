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

    // Update is called once per frame
    public virtual void Update()
    {
        if (isActive == false)
            return;


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
