using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    SphereCollider sc;
    AudioSource ac;

    

    private void Start()
    {
        sc = GetComponent<SphereCollider>();
        ac = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "MainArenaFloor")
        {
            
            
            ac.Play();
        }
    }
}
