using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour

{
    public int timer;
    public TextMeshProUGUI timerText;
    public GameEnding gameEnding;

    // Start is called before the first frame update
    void Start()
    {
        timer = 90;
        InvokeRepeating("Countdown", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = "SECONDS LEFT: " + timer;
        if (timer == 0)
        {
            gameEnding.CaughtPlayer ();
        }
    }

    void Countdown()
    {
       timer--;
    }

}
