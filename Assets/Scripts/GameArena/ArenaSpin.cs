using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaSpin : MonoBehaviour
{
    public float spinSpeed;

    public bool hasStartedSpin;

    private Quaternion rotation;

    private void Start()
    {

        rotation = this.transform.rotation;
        
    }
    // Update is called once per frame
    void Update()
    {

        if (hasStartedSpin)
        {
            this.transform.Rotate(0, spinSpeed * Time.deltaTime, 0, Space.World);
        }
        else
        {
            this.transform.rotation = rotation;
        }


    }
}
