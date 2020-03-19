using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyFollowShoot : MonoBehaviour
{
    public GameObject currentProjectile;
    Bullet_Controller bController;

    public float bulletSpeed;
    public float shootCD;
    [HideInInspector] public float shootCDTimer;

    public float shootCDBetweenShots;

    public int numberOfShoot;
    public Ennemy followControl;


    // Start is called before the first frame update
    void Start()
    {
        followControl = GetComponent<Ennemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (followControl.isActive == false)
            return;
        if (shootCDTimer < 0)
        {
            StartCoroutine(SeveralShoots(numberOfShoot));
            shootCDTimer = shootCD;
        }
        else
        {
            shootCDTimer -= Time.deltaTime;
        }
    }

    IEnumerator SeveralShoots(int numberOfShoots)
    {
        
        for (int i = 0; i < numberOfShoots; i++)
        {
            Shoot();
            yield return new WaitForSeconds(shootCDBetweenShots);

        }

    }

    void Shoot()
    {
        GameObject bullet = Instantiate(currentProjectile);

        bullet.transform.position = transform.position;
    }
}
