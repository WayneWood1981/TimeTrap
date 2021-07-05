using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallSpawning : MonoBehaviour
{

    public Rigidbody[] rbs;

    AudioSource audioSource;
    PlayerManager playerManager;
    public AudioClip[] audioClips;

    public List<int> usedValues;

    public float ballLaunchSpeed;

    public Transform spawnPoint;

    public float currentTimer;
    public float maxTimer;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentTimer = maxTimer;
        playerManager = FindObjectOfType<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerManager.gameHasStarted)
        {
            if (currentTimer > 0)
            {
                currentTimer -= 1 * Time.deltaTime;
            }
            else if (currentTimer <= 0)
            {
                SpawnNewBalls();
                currentTimer = maxTimer;

            }
        }
        
    }

    public void SpawnNewBalls()
    {
        usedValues = new List<int>();

        for (int i = 0; i < rbs.Length; i++)
        {
            int val = UnityEngine.Random.Range(0, rbs.Length);

            while (usedValues.Contains(val))
            {
                val = UnityEngine.Random.Range(0, rbs.Length);
            }

            usedValues.Add(val);
        }

        Rigidbody ball1 = Instantiate(rbs[usedValues[0]], spawnPoint.position, spawnPoint.rotation);
        ball1.AddForce(new Vector3(UnityEngine.Random.Range(-4, 4), 15, UnityEngine.Random.Range(-4, 4)), ForceMode.Impulse);
        ball1.transform.parent = GameObject.Find("GAMEARENA").transform;
        audioSource.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
        audioSource.volume = 0.5f;
        Invoke("NextBall", ballLaunchSpeed);
        
    }

    void NextBall()
    {
        Rigidbody ball2 = Instantiate(rbs[usedValues[1]], spawnPoint.position, spawnPoint.rotation);
        ball2.AddForce(new Vector3(UnityEngine.Random.Range(-4, 4), 15, UnityEngine.Random.Range(-4, 4)), ForceMode.Impulse);
        ball2.transform.parent = GameObject.Find("GAMEARENA").transform;
        audioSource.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
        audioSource.volume = 0.5f;
        Invoke("NextBall1", ballLaunchSpeed);
    }
    void NextBall1()
    {
        Rigidbody ball3 = Instantiate(rbs[usedValues[2]], spawnPoint.position, spawnPoint.rotation);
        ball3.AddForce(new Vector3(UnityEngine.Random.Range(-4, 4), 15, UnityEngine.Random.Range(-4, 4)), ForceMode.Impulse);
        ball3.transform.parent = GameObject.Find("GAMEARENA").transform;
        audioSource.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
        audioSource.volume = 0.5f;
        Invoke("NextBall2", ballLaunchSpeed);
    }
    void NextBall2()
    {
        Rigidbody ball4 = Instantiate(rbs[usedValues[3]], spawnPoint.position, spawnPoint.rotation);
        ball4.AddForce(new Vector3(UnityEngine.Random.Range(-4, 4), 15, UnityEngine.Random.Range(-4, 4)), ForceMode.Impulse);
        ball4.transform.parent = GameObject.Find("GAMEARENA").transform;
        audioSource.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
        audioSource.volume = 0.5f;
        Invoke("NextBall3", ballLaunchSpeed);
    }
    void NextBall3()
    {
        Rigidbody ball5 = Instantiate(rbs[usedValues[4]], spawnPoint.position, spawnPoint.rotation);
        ball5.AddForce(new Vector3(UnityEngine.Random.Range(-4, 4), 15, UnityEngine.Random.Range(-4, 4)), ForceMode.Impulse);
        ball5.transform.parent = GameObject.Find("GAMEARENA").transform;
        audioSource.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
        audioSource.volume = 0.5f;

    }






}
