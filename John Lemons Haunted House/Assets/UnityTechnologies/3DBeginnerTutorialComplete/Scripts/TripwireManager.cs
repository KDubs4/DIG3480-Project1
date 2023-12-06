using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TripwireManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "SCORE: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void earnScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
    }
}
