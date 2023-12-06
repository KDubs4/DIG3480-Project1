using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tripwire : MonoBehaviour
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

    private void OnTriggerEnter(Collider Tripwire)
    {
        if (Tripwire.gameObject.tag == "Tripwire")
        {
            score++;
            scoreText.text = "SCORE: " + score;
            Debug.Log("trip");
        }
    }
}
