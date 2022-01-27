using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoneYes : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void No()
    {
        anim.SetBool("Yes", false);
    }

    void Yes()
    {
        anim.SetBool("Yes", true);
    }
}
