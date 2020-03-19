using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyFollowShoot : MonoBehaviour
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
            StartCoroutine(SeveralShoots(3));
            shootCDTimer = shootCD;
        }
        else
        {
            shootCDTimer -= Time.deltaTime;
        }
    }

    IEnumerator SeveralShoots(int numberOfShoots)
    {

        for(int i = 0; i < numberOfShoots; i++)
        {
            Shoot();

            yield return new WaitForSeconds(0.2f);
        }


    }

    void Shoot()
    {
        GameObject bullet = Instantiate(currentProjectile);

        bullet.transform.position = transform.position;

        bullet.GetComponent<Bullet_Controller>().launchSpeed = bulletSpeed;
    }
}
