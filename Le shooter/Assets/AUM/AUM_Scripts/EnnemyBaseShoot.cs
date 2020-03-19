using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBaseShoot : MonoBehaviour
{
    public GameObject currentProjectile;
    Bullet_Controller bController;

    public float bulletSpeed;
    public float shootCD;
    [HideInInspector] public float shootCDTimer;
    public Ennemy baseControl;


    // Start is called before the first frame update
    void Start()
    {
        baseControl = GetComponent<Ennemy>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (baseControl.isActive == false)
            return;
        if (shootCDTimer < 0)
        {
            Shoot();
            shootCDTimer = shootCD;
        }
        else
        {
            shootCDTimer -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(currentProjectile);

        bullet.transform.position = transform.position;

        bullet.GetComponent<Bullet_Controller>().launchSpeed = bulletSpeed;
    }
}
