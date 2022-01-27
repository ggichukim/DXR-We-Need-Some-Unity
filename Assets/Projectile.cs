using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour


{
    public GameObject explosionFx;

    void OnParticleCollision(GameObject other)
    {
        FindObjectOfType<Score>().AddScore();
        Instantiate(explosionFx, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
