using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StopWatchForladerrum : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public Text currentTimeText;
    int randomBolig;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        stopwatchActive = true;

        randomBolig = UnityEngine.Random.Range(1, 25);
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;

            TimeSpan time = TimeSpan.FromSeconds(currentTime);

            currentTimeText.text = "Forlader rum: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
        }
    }

    public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void StopStopwatch()
    {
        stopwatchActive = false;
    }
}