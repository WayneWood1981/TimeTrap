using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ColourChange : MonoBehaviour
{

    
    public Image[] images;
    public Sprite[] newImages;
    public Image[] pressToJoins;

    public Sprite Ready;
    
    public GameObject warningText;
    public GameObject instructionText;
    bool displayingWarning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ChangePlayersColour(int index, int currentColourNumber)
    {
        
        images[index].sprite = newImages[currentColourNumber];
    }

    public void PlayerHasJoinedLobby(int index)
    {
        pressToJoins[index].gameObject.SetActive(false);
        instructionText.SetActive(true);
    }

    public void PlayerReadyUp(int index)
    {
        pressToJoins[index].gameObject.SetActive(true);
        pressToJoins[index].sprite = Ready;
    }

    public void DisplayPlayerWarning()
    {
        
        warningText.SetActive(true);
        StartCoroutine(Fadeout());
    }


    IEnumerator Fadeout()
    {
        yield return new WaitForSeconds(3);
        warningText.SetActive(false);
    }
    

}
