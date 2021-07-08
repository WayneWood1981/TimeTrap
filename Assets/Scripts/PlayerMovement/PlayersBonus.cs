using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayersBonus : MonoBehaviour
{

    Controls controls;
    ColourChange colourChange;
    PlayerInput playerInput;
    PlayerManager playerManager;
    AudioSource audioSource;

    public AudioClip click;

    public int currentColourNumber;
    
    public bool hasRWBonus;
    public bool hasPPBonus;
    public bool hasFFBonus;

    public bool isReady;

    public bool hasLoaded;

    public GameObject[] Spheres;
    public Material[] playerMaterials;

    private void Awake()
    {
        controls = new Controls();
        colourChange = FindObjectOfType<ColourChange>();
        
        
        
    }

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerManager = FindObjectOfType<PlayerManager>();
        audioSource = GetComponent<AudioSource>();
        currentColourNumber = 4;
        Invoke("hasLoadedIn", 0.5f);
        
    }

    private void hasLoadedIn()
    {
        hasLoaded = true;
        Debug.Log("??");
        
    }

    private void IsColourAvailable()
    {
        PlayersBonus[] otherPlayersScripts = FindObjectsOfType<PlayersBonus>();
        
        if (playerManager.playerAmount == 1)
        {
            colourChange.ChangePlayersColour(playerInput.playerIndex, currentColourNumber);
        }
        else
        {
            
            foreach (PlayersBonus p in otherPlayersScripts)
            {
                if (p != this)
                {
                    if (p.currentColourNumber != currentColourNumber || p.currentColourNumber == 4)
                    {
                        colourChange.ChangePlayersColour(playerInput.playerIndex, currentColourNumber);
                    }
                    else
                    {
                        currentColourNumber += 1;
                        IsColourAvailable();
                    }
                }
            }
        }
        

        
        //colourChange.ChangePlayersColour(playersIndex, currentColourNumber);
    }

    public void LeftDPad(InputAction.CallbackContext obj)
    {
        if (!this.gameObject.activeInHierarchy) return;
        if (obj.performed && playerManager.isInLobbyScreen) // AND IS STILL IN LOBBY needds to be added
        {
            audioSource.PlayOneShot(click);
            currentColourNumber -= 1;
            if (currentColourNumber < 0)
            {
                currentColourNumber = 4;
            }

            IsColourAvailable();
                
        }
    }

    public void RightDPad(InputAction.CallbackContext obj)
    {
        
        if (!this.gameObject.activeInHierarchy) return;
        if(obj.performed && playerManager.isInLobbyScreen) // AND IS STILL IN LOBBY needds to be added
        {
            audioSource.PlayOneShot(click);
            currentColourNumber += 1;
            if (currentColourNumber > 4)
            {
                currentColourNumber = 0;
            }

            IsColourAvailable();

        }
        
    }


    public void Slow(InputAction.CallbackContext obj)
    {

        if (!this.gameObject.activeInHierarchy) return;
        if (obj.performed && hasRWBonus)
        {
            hasRWBonus = false;
            CreateSphere("RewindSphere", transform.tag, transform.position);
            
            
        }
    }


    public void Pause(InputAction.CallbackContext obj)
    {
        if (!this.gameObject.activeInHierarchy) return;

        if (hasLoaded)
        {

            if (obj.performed && hasPPBonus && playerManager.isInLobbyScreen == false)
            {
                hasPPBonus = false;
                CreateSphere("PauseSphere", transform.tag, transform.position);
            }
            if (obj.performed && playerManager.isInLobbyScreen && currentColourNumber != 4 && playerManager.playerAmount > 1)
            {
                colourChange.PlayerReadyUp(playerInput.playerIndex);
                playerManager.readyPlayers += 1;


                playerManager.BeginGamePlayerPosition(playerInput, currentColourNumber);
                switch (currentColourNumber)
                {
                    case 0:
                        Transform base1 = GameObject.Find("Base1Green").transform;

                        base1.GetComponent<BaseBonusParticles>().getPlayer(this.transform.tag);
                        base1.GetComponentInChildren<Score>().playerTag = (this.transform.tag);

                        break;
                    case 1:
                        Transform base2 = GameObject.Find("Base2Purple").transform;
                        base2.GetComponent<BaseBonusParticles>().getPlayer(this.transform.tag);
                        base2.GetComponentInChildren<Score>().playerTag = (this.transform.tag);

                        break;
                    case 2:
                        Transform base3 = GameObject.Find("Base3Orange").transform;
                        base3.GetComponent<BaseBonusParticles>().getPlayer(this.transform.tag);
                        base3.GetComponentInChildren<Score>().playerTag = (this.transform.tag);

                        break;
                    case 3:
                        Transform base4 = GameObject.Find("Base4Blue").transform;
                        base4.GetComponent<BaseBonusParticles>().getPlayer(this.transform.tag);
                        base4.GetComponentInChildren<Score>().playerTag = (this.transform.tag);

                        break;

                }

            }
            else if (obj.performed && playerManager.isInLobbyScreen && currentColourNumber != 4 && playerManager.playerAmount < 2)
            {
                colourChange.DisplayPlayerWarning();
            }
            else if (obj.performed && playerManager.gameHasEnded)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    public void FastForward(InputAction.CallbackContext obj)
    {

        if (!this.gameObject.activeInHierarchy) return;
        if (obj.performed && hasFFBonus)
        {
            hasFFBonus = false;
            CreateSphere("ForwardSphere", transform.tag, transform.position);
        }
    }

    public void CreateSphere(string sphereType, string playerTag, Vector3 pos)
    {
        foreach (var sphere in Spheres)
        {
            if (sphere.transform.tag == sphereType)
            {
                GameObject createdSphere = Instantiate(sphere, pos, transform.rotation);
                createdSphere.transform.parent = GameObject.Find("GAMEARENA").transform;
                createdSphere.GetComponent<SphereMechanics>().ignoreTag = playerTag;
                switch (this.transform.tag)
                {
                    case "Player1":
                        createdSphere.GetComponent<MeshRenderer>().material = playerMaterials[0];
                        break;
                    case "Player2":
                        createdSphere.GetComponent<MeshRenderer>().material = playerMaterials[1];
                        break;
                    case "Player3":
                        createdSphere.GetComponent<MeshRenderer>().material = playerMaterials[2];
                        break;
                    case "Player4":
                        createdSphere.GetComponent<MeshRenderer>().material = playerMaterials[3];
                        break;

                }
                StartCoroutine(deleteSphere(10.0f, createdSphere));
                
            }
        }
    }

    IEnumerator deleteSphere(float time, GameObject sphere)
    {
        yield return new WaitForSeconds(time);
        List<GameObject> ballsInsideSphere = sphere.GetComponent<SphereMechanics>().objectsCaught;
        foreach (var ball in ballsInsideSphere)
        {
            if (ball != null)
            {
                ball.GetComponent<EffectListener>().isEffectedbyRewind = false;
                ball.GetComponent<EffectListener>().isEffectedbyPause = false;
                ball.GetComponent<EffectListener>().isEffectedbyForward = false;
            }
            
        }
        Destroy(sphere);
    }
}
