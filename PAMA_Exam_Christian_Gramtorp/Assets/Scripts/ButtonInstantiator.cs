using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonInstantiator : MonoBehaviour
{
    public GameObject canvas;
    public GameObject[] button;

    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randomButton;

    void Start()
    {
        //StartCoroutine(WaitSpawner());
    }
    
    public  void CloseAndStart()
    {
        StopCoroutine(WaitSpawner());
        StartCoroutine(WaitSpawner());
    }

    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    void lerpPusher()
    {
        
    }

    IEnumerator WaitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randomButton = Random.Range(0, 5);

            GameObject newButton = Instantiate(button[randomButton]) as GameObject;
            newButton.transform.SetParent(canvas.transform, false);
            Component[] allExisitingButtons = canvas.GetComponentsInChildren<Lerp>();
            foreach (Lerp lerp in allExisitingButtons)
            {
                if (lerp.gameObject != newButton)
                {
                    lerp.StartLerp();
                }
            }
            yield return new WaitForSeconds(spawnWait);
        }
    }
}

