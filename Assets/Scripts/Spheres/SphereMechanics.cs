using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMechanics : MonoBehaviour
{


    public string ignoreTag;

    public bool isRewinding;

    public float gravityMultiplier;

    GameObject playerWhoCastSphere;

    private string thisSphereTag;

    public List<GameObject> objectsCaught = new List<GameObject>();

    private void Start()
    {
        thisSphereTag = this.transform.tag;

        
    }

    private void Update()
    {
        //This shrinks spheres over time
        //this.transform.localScale -= new Vector3(1.2f, 1.2f, 1.2f) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {

        switch (thisSphereTag)
        {
            case "RewindSphere":
                if (other.transform.tag != ignoreTag)
                {
                    other.GetComponent<EffectListener>().isEffectedbyRewind = true;
                    objectsCaught.Add(other.gameObject);
                    other.GetComponent<TimeBody>().StartRewind();
                }
                
                
                
                break;
            case "PauseSphere":
                if (other.transform.tag != ignoreTag)
                {
                    
                    other.GetComponent<EffectListener>().isEffectedbyPause = true;
                    objectsCaught.Add(other.gameObject);
                }
                

                break;
            case "ForwardSphere":
                
                other.GetComponent<EffectListener>().isEffectedbyForward = true;
                other.GetComponent<Rigidbody>().AddForce(Physics.gravity * (gravityMultiplier - 1f), ForceMode.Impulse);
                objectsCaught.Add(other.gameObject);

                
                break;


        }
        
    }

    


    private void OnTriggerExit(Collider other)
    {
        switch (thisSphereTag)
        {
            //case "RewindSphere":


                //break;
            case "PauseSphere":
                if (other.transform.tag != ignoreTag)
                {
                    // create a listener on all objects to change speed accordingly??
                    other.GetComponent<EffectListener>().isEffectedbyPause = false;

                }

                break;
            case "ForwardSphere":
                //other.GetComponent<EffectListener>().isEffectedbyForward = false;
                other.GetComponent<Rigidbody>().AddForce(Physics.gravity / (gravityMultiplier - 1f), ForceMode.Impulse);

                break;


        }
    }

    




}
