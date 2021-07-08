using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{

    AudioSource audioSource;
    Winner winner;
    public float playersCurrentScore;

    public TextMeshPro playersScore;

    PlayerManager playerManager;

    public ParticleSystem[] pss;

    public AudioClip debuff;

    public string playerTag;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playersCurrentScore = 60;
        playerManager = FindObjectOfType<PlayerManager>();
        playersScore = GetComponent<TextMeshPro>();
        winner = FindObjectOfType<Winner>();
        UpdateScore();
    }


    public void UpdateScore()
    {
        
        string textScrore = playersCurrentScore.ToString();

        
        
        if (playersScore)
        {
            playersScore.SetText(textScrore);
            playersScore.text = textScrore;
            playersScore.SetAllDirty();
            playersScore.ForceMeshUpdate(true);
        }
        else
        {
            Debug.Log("No playersScore");
        }
        
        
    }

    private void Update()
    {
        if (playerManager.gameHasStarted == true)
        {
            
            string textScrore = Mathf.RoundToInt(playersCurrentScore).ToString();
            playersCurrentScore -= Time.deltaTime;
            playersScore.SetText(textScrore);
            playersScore.text = textScrore;
            playersScore.SetAllDirty();
            playersScore.ForceMeshUpdate(true);
            if (playersCurrentScore <= 0)
            {
                playersCurrentScore = 0;
                PlayersSessionEnded();
            }
        }
        
    }

    private void PlayersSessionEnded()
    {
        
        switch (transform.name)
        {
            case "Player1Score":
                
                GameObject player = GameObject.Find(playerTag);
                if (player)
                {
                    player.GetComponent<PlayerMovement>().hasDied = true;
                    Animator pAnim = player.GetComponentInChildren<Animator>();
                    pAnim.SetFloat("Horizontal", 0.0f);
                    pAnim.SetFloat("Vertical", 0.0f);
                    ParticleSystem player1Ps = Instantiate(pss[player.GetComponent<PlayersBonus>().currentColourNumber], player.transform.position, player.transform.rotation);
                    audioSource.PlayOneShot(debuff);
                    winner.players.Remove(player);
                    Destroy(player);
                }
                
                break;
            case "Player2Score":
                GameObject player2 = GameObject.Find(playerTag);
                if (player2)
                {
                    player2.GetComponent<PlayerMovement>().hasDied = true;
                    Animator pAnim2 = player2.GetComponentInChildren<Animator>();
                    pAnim2.SetFloat("Horizontal", 0.0f);
                    pAnim2.SetFloat("Vertical", 0.0f);
                    ParticleSystem player2Ps = Instantiate(pss[player2.GetComponent<PlayersBonus>().currentColourNumber], player2.transform.position, player2.transform.rotation);
                    audioSource.PlayOneShot(debuff);
                    winner.players.Remove(player2);
                    Destroy(player2);
                }
                
                break;
            case "Player3Score":
                GameObject player3 = GameObject.Find(playerTag);
                if (player3)
                {
                    player3.GetComponent<PlayerMovement>().hasDied = true;
                    Animator pAnim3 = player3.GetComponentInChildren<Animator>();
                    pAnim3.SetFloat("Horizontal", 0.0f);
                    pAnim3.SetFloat("Vertical", 0.0f);
                    ParticleSystem player3Ps = Instantiate(pss[player3.GetComponent<PlayersBonus>().currentColourNumber], player3.transform.position, player3.transform.rotation);
                    audioSource.PlayOneShot(debuff);
                    winner.players.Remove(player3);
                    Destroy(player3);
                }
                
                break;
            case "Player4Score":
                GameObject player4 = GameObject.Find(playerTag);
                if (player4)
                {
                    player4.GetComponent<PlayerMovement>().hasDied = true;
                    Animator pAnim4 = player4.GetComponentInChildren<Animator>();
                    pAnim4.SetFloat("Horizontal", 0.0f);
                    pAnim4.SetFloat("Vertical", 0.0f);
                    ParticleSystem player4Ps = Instantiate(pss[player4.GetComponent<PlayersBonus>().currentColourNumber], player4.transform.position, player4.transform.rotation);
                    audioSource.PlayOneShot(debuff);
                    winner.players.Remove(player4);
                    Destroy(player4);
                }
                
                break;
        }
    }
}
