using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    SpriteRenderer sr;

    public float xVel;
    public float yVel;
    public Transform SpawnPointLeft;
    public Transform SpawnPointRight;

    public projectile projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        if (xVel == 0 && yVel == 0)
        {
            xVel = 7.0f;
        }

        if (!SpawnPointLeft || !SpawnPointRight || !projectilePrefab)
        {
            Debug.Log("Set default values");
        }



    }

    public void Fire()
    {
        if (!sr.flipX)
        {
            projectile curProjectile = Instantiate(projectilePrefab, SpawnPointRight.position, Quaternion.identity);
            curProjectile.SetVelocity(xVel, yVel);

        }
        else
        {
            projectile curProjectile = Instantiate(projectilePrefab, SpawnPointLeft.position, Quaternion.identity);
            curProjectile.SetVelocity(-xVel, yVel);

        }

    }



}