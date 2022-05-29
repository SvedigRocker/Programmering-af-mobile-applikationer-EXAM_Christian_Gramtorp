using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class WhiteButtonBehavior : MonoBehaviour
{

    Button button;
    public bool buttonPress = false;
    Image color;
    

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        
        button.onClick.AddListener(ColorChange); // Starter eventet
    }

    // Update is called once per frame
    public void ColorChange()
    {
        
        if (!buttonPress)
        {
            
            buttonPress = true;
            ChangeToYellow();
        }
        else if (buttonPress)
        {   
            
            buttonPress = false;
            ChangeToWhite();
        }
        
        //GetComponent<Image>().color = Color.yellow;
    }

    private void OnDestroy()
    {  
        button.onClick.RemoveListener(ColorChange); // Afslutter eventet
    }
    public void ChangeToYellow()
    {
        GetComponent<Image>().color = Color.yellow;
        GetComponentInChildren<Text>().color = Color.black;
        
        Debug.Log("gul");
    }
    public void ChangeToWhite()
    {
        
        GetComponent<Image>().color = Color.white;
        GetComponentInChildren<Text>().color = Color.black;
        
        Debug.Log("Hvid");
    }
}
