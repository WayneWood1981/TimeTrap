using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRotation : MonoBehaviour
{
    public Transform score;
    public Transform rewind;
    public Transform pause;
    public Transform fastforward;


    Quaternion iniRot;
    // Start is called before the first frame update
    void Start()
    {
        iniRot = score.transform.rotation;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        score.transform.rotation = iniRot;
        rewind.transform.rotation = iniRot;
        pause.transform.rotation = iniRot;
        fastforward.transform.rotation = iniRot;

    }
}
