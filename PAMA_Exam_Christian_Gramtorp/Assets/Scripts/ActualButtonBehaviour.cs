using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualButtonBehaviour : MonoBehaviour
{
    // Button variable
    Button button;

    // Boolean variable used to check which color is currently active on the button
    public bool originalColor = true;

    // Start is called before the first frame update
    void Start()
    {
        // Finds the button component from the game object (the alarm prefabs) and stores it in the button variable
        button = GetComponent<Button>();

        // Adds an onClick event which triggers the ColorChange method.
        button.onClick.AddListener(ColorChange);
    }

    // Update is called once per frame
    public void ColorChange()
    {
        if (originalColor)
        {
            originalColor = false;
            ChangeToYellow();
        }
        else if (gameObject.tag == "WhiteAlarms")
        {
            originalColor = true;
            ChangeToWhite();
        }
        else if (gameObject.tag == "RedAlarms")
        {
            originalColor = true;
            ChangeToRed();
        }
    }
    /// <summary>
    /// First the ColorChange method checks if the original color is currently active on the alarm prefab. Then it triggers the ChangeToYellow method which changes the color to yellow.
    /// If the original collor is not currently active, the methods checks which tag is active on the game object and then triggers another method accordingly.
    /// </summary>


    private void OnDestroy()
    {
        button.onClick.RemoveListener(ColorChange); // Removes the event listener
    }

    // Methods used in ColorChange()
    public void ChangeToYellow()
    {
        GetComponent<Image>().color = Color.yellow;
        GetComponentInChildren<Text>().color = Color.black;
    }

    public void ChangeToWhite()
    {
        GetComponent<Image>().color = Color.white;
        GetComponentInChildren<Text>().color = Color.black;
    }

    public void ChangeToRed()
    {
        GetComponent<Image>().color = Color.red;
        GetComponentInChildren<Text>().color = Color.white;
    }
    /// <summary>
    /// These methods change the color of the Image component on the game object to either yellow, white or red.
    /// They also change the color of the Text component on the game object (or any of its children) to black or white.
    /// </summary>
}
