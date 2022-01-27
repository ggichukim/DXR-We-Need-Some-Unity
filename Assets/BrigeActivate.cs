using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrigeActivate : MonoBehaviour
{
    public Animator anim;
    public Animator anim1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("close", true);
            anim1.SetBool("Yes", true);
        }
    }
}
