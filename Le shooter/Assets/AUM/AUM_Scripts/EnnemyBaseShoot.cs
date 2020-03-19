using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBaseShoot : MonoBehaviour
{
    public GameObject currentProjectile;
    Bullet_Controller bController;

    public float bulletSpeed;
    [HideInInspector] public float shootCD;
    [HideInInspector] public float shootCDTimer;


    // Start is called before the first frame update
    void Start()
    {
        bController = currentProjectile.GetComponent<Bullet_Controller>();
        shootCD = bController.launchCD;
    }

    // Update is called once per frame
    void Update()
    {
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
