using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public int life;

    public bool isActive = false;

    private Score score;

    private void FixedUpdate()
    {
        
    }

    public void TakeDamage(int damage)
    {
        life -= damage;

        if(life <= 0)
        {
            Destroy(gameObject);
            score = GameObject.FindWithTag("scoremanager").GetComponent<Score>();
            score.score += 50;
        }
    }
}
