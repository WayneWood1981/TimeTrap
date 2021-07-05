using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class testScript : MonoBehaviour
{

    int score;

    TextMeshPro textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = score.ToString();
        score++;
    }
}
