using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{

    

    private void OnTriggerEnter(Collider other)
    {
        switch (other.transform.tag)
        {
            case "Player1":
                other.transform.GetComponentInChildren<Animator>().SetBool("isFalling", true);
                other.transform.GetComponent<Rigidbody>().drag = 0;
                other.transform.GetComponent<PlayerMovement>().downwardForce = 1;
                other.transform.parent = null;
                
                break;
            case "Player2":
                other.transform.GetComponentInChildren<Animator>().SetBool("isFalling", true);
                other.transform.GetComponent<Rigidbody>().drag = 0;
                other.transform.GetComponent<PlayerMovement>().downwardForce = 1;
                other.transform.parent = null;
                break;
            case "Player3":
                other.transform.GetComponentInChildren<Animator>().SetBool("isFalling", true);
                other.transform.GetComponent<Rigidbody>().drag = 0;
                other.transform.GetComponent<PlayerMovement>().downwardForce = 1;
                other.transform.parent = null;
                break;
            case "Player4":
                other.transform.GetComponentInChildren<Animator>().SetBool("isFalling", true);
                other.transform.GetComponent<Rigidbody>().drag = 0;
                other.transform.GetComponent<PlayerMovement>().downwardForce = 1;
                other.transform.parent = null;
                break;
        }
    }
}
