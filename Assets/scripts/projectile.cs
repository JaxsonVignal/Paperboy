using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class projectile : MonoBehaviour
{

    [Range(1, 50)] public float lifeTime;
    // Start is called before the first frame update

    [HideInInspector] public float xVel;
    [HideInInspector] public float yVel;

    void Start()
    {
        if (lifeTime <= 0)
        {
            lifeTime = 2.0f;
        }

        Destroy(gameObject, lifeTime);
    }

    public void SetVelocity(float x, float y)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(x, y);
    }







}