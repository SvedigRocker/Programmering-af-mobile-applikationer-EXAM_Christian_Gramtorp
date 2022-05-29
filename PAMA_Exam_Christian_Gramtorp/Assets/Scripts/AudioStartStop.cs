using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class AudioStartStop : MonoBehaviour
{
    AudioSource myAudioSource;

    //Play the music
    //public bool Play;
    public float snoozeTime;
    //Detect when you use the toggle, ensures music isn�t played multiple times
    public bool m_ToggleChange = true;
    public bool play = true;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        myAudioSource = GetComponent<AudioSource>();
        StartCoroutine(SoundOut());

        //Ensure the toggle is set to true for the music to play at start-up
    }

    IEnumerator SoundOut()
    {
    while (play == true)
    {
        if (this.GetComponent<AudioStartStop>().enabled == true)
        {
            AudioSource myAudioSource = this.GetComponent<AudioSource>();
            myAudioSource.PlayOneShot(myAudioSource.clip);
            yield return new WaitForSeconds(snoozeTime);
        }
    }

}
    public void StopSound()
    {
        if (play == true)
        {
        play = false; 
        myAudioSource.GetComponent<AudioSource>().volume = 0.0f;
        StopCoroutine(SoundOut());
        Debug.Log("Test stop");
        }
        else if (play == false)
        {
        play = true;
        myAudioSource.GetComponent<AudioSource>().volume = 1.0f;
        StartCoroutine(SoundOut());
        Debug.Log("Test start");
        }
        //m_ToggleChange = false;

    }
}