using UnityEngine;
using System.Collections;

public class EnemySphere : MonoBehaviour {

    public float hitPoints = 1f;
    public GameObject steamEffect;

    void Update()
    {
        
    }
    void OnCollisionEnter(Collision c)
    {
        Destroy(gameObject);
        GameObject steam = (GameObject)Instantiate(steamEffect, transform.position, transform.rotation);
        Destroy(steam, 2);

        Debug.Log("Sphere was hit by a " + c.gameObject.name);
        if (c.gameObject.name == "Bullet(Clone)")
        {
            RainDrops.HitBullet();
        }
        else
        {
            RainDrops.HitGround();
        }
    }
}
