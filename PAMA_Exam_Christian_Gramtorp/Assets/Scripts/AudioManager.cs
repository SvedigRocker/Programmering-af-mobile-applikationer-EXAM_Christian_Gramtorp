using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
//For at scriptet skal virke, skal i bruge et empty gameobject og en audiosource og en audiolistener. 
//Dette script skal sættes på gameobjectet, text.text skal sættes trækkes op i inspectoren, hvis vi har en tekst, der skal vises.
{
    // Singleton instance.
    public static AudioManager Instance = null;

    // med Threshold skal i huske at tjekke inspectoren, om den står rigtigt derinde. 5 er en ret god værdi, vil jeg sige.
    public float threshold = 200f;
    public bool trigger = false;
    public float snoozeTime = 30f;

    // Initialize the singleton instance.
    private void Awake()
    {
        // If there is not already an instance of SoundManager, set it to this.
        if (Instance == null)
        {
            Instance = this;
        }
        //If an instance already exists, destroy whatever this object is to enforce the singleton.
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        // The AudioManager won't be destroyed when loading a new scene.
        DontDestroyOnLoad(gameObject);

    }

    void Update()
    {
        if (Input.acceleration.magnitude > threshold)
        {
            Debug.Log("PlayTest aktiveret");
            if (trigger == false)
            {
                trigger = true;
                AudioListener.pause = true;
                AudioListener.volume = 0;

                Invoke("TurnUpVolume", snoozeTime);
            }
        }

        else if (trigger == true)
        {
            trigger = false;
        }

    }
    void TurnUpVolume()
    {
        AudioListener.pause = false;
        AudioListener.volume = 1;
    }
}