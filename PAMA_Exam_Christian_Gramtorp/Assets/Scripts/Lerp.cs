using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Dette script er lavet med inspiration fra et script fundet på Unity's Forum. https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html

public class Lerp : MonoBehaviour
{
    // Defining start- and end-markers for our alarms. 
    public Transform startMarker;
    public Transform endMarker;
    public float endY;
    // Movement speed in units per second for the markers.
    public float speed = 1.0F;

    // Time when the alarms movements start.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;
    
    void Awake() 
    {
        Invoke("Start", 5.0f);  
        
    }
    void Start()
    {
        
        // Keep a note of the time the movement started.
        

        // Calculate the journey length.
        //journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        
    }

    // Move to the target end position.
    void Update()
    {
        // Distance moved equals elapsed time times speed..
        //float distCovered = (Time.time - startTime) * speed;

        

        // Fraction of journey completed equals current distance divided by total distance.
        //float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        
    }

    public void StartLerp()
    {
        StartCoroutine(lerpPusher());
    }

    IEnumerator lerpPusher()
    {
        startTime = Time.time;
        endY = transform.position.y - 225;  
        float t = (Time.time - startTime);
        while (Mathf.Abs(endY - transform.position.y) > 0.1f)
        {
            //transform.position = new Vector3(transform.position.x, Mathf.SmoothStep(transform.position.y, endY, t), transform.position.z);
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, endY, transform.position.z), 7.0f * Time.deltaTime);
            yield return null;
        }
    }
}
