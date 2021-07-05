using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour
{

    public bool isRewinding = false;

    public float rewindTimeByAmount = 5;

    Rigidbody rb;
    AudioSource audioSource;
    public AudioClip rewindSound;
    

    

    List<PointInTime> pointsInTime;

    // Start is called before the first frame update
    void Start()
    {
        pointsInTime = new List<PointInTime>();
        audioSource = GetComponent<AudioSource>();
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartRewind()
    {
        isRewinding = true;
        rb.isKinematic = true;
        if (this.transform.tag == "Player1" || this.transform.tag == "Player2" || this.transform.tag == "Player3" || this.transform.tag == "Player4")
        {
            this.transform.GetComponent<PlayerMovement>().isRewinding = true;
            
        }
    }

    public void StopRewind()
    {
        isRewinding = false;
        rb.isKinematic = false;
        if (this.transform.tag == "Player1" || this.transform.tag == "Player2" || this.transform.tag == "Player3" || this.transform.tag == "Player4")
        {
            this.transform.GetComponent<PlayerMovement>().isRewinding = false;
        }
    }

    private void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        }
        else
        {
            Record();
            
        }
    }

    public void Record()
    {
        if (pointsInTime.Count > Math.Round(rewindTimeByAmount / Time.fixedDeltaTime))
        {
            pointsInTime.RemoveAt(pointsInTime.Count - 1);
        }

        pointsInTime.Insert(0, new PointInTime(this.transform.localPosition, this.transform.rotation));
    }

    public void Rewind()
    {
        if (pointsInTime.Count > 0)
        {
            
            
            PointInTime pointInTime = pointsInTime[0];
            this.transform.position = pointInTime.position;
            this.transform.rotation = pointInTime.rotation;
            pointsInTime.RemoveAt(0);

        }
        else
        {
            StopRewind();
            

        }
        
    }
}
