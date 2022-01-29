using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour


{
    public GameObject explosionFx;
    public AudioSource explosionAudio;
    
    void start()
    {
        
    }

    void OnParticleCollision(GameObject other)
    {
        if (this.tag == "Correct") FindObjectOfType<Score>().AddScore();
        Instantiate(explosionFx, transform.position, Quaternion.identity);
        Instantiate(explosionAudio, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
