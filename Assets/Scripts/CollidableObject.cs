using UnityEngine;
using System.Collections;

public class CollidableObject : MonoBehaviour {
    public float bulletLifeSpan = 5;
    public GameObject explosion;

    void Start()
    {
        Destroy(gameObject, bulletLifeSpan);
    }

    void OnCollisionEnter(Collision collision)
    {
        float flameDuration = (collision.gameObject.name == "ShootableRainSphere") ? 1f : 10f;

        Debug.Log("Collided with " + collision.gameObject.name);
        Destroy(gameObject);
        GameObject newexplosion = (GameObject)Instantiate(explosion, transform.position, transform.rotation);

        Destroy(newexplosion, flameDuration);
    }
}
