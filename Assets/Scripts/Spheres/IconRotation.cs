using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconRotation : MonoBehaviour
{

    private Transform icon;

    Quaternion iniRot;

    private void Awake()
    {
        icon = gameObject.transform.GetChild(0);
        
    }
    // Start is called before the first frame update
    void Start()
    {

        iniRot = Quaternion.Euler(90.0f, 0.0f, 0.0f);
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        icon.transform.rotation = iniRot;
        

    }
}
