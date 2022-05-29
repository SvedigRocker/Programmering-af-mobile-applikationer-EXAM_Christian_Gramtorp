using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       // Unity UI is a UI toolkit for developing user interfaces for games and applications

public class YesButton : MonoBehaviour
{

    [SerializeField] GameObject guideMenu;      // SerializeField 
    [SerializeField] GameObject guideMenuTwo;
    [SerializeField] GameObject guideMenuThree;
    [SerializeField] GameObject guideMenuFour;

    public ButtonInstantiator myButtonInstantiator;

    void Start()

    {
        GetComponent<ButtonInstantiator>();

    }

    public void CloserFirstButtons()
    {
        guideMenu.SetActive(false);
        guideMenuTwo.SetActive(false);
        guideMenuThree.SetActive(false);
    }

    public void Closer()
    {
        myButtonInstantiator.CloseAndStart();
        guideMenu.SetActive(false);
        guideMenuTwo.SetActive(false);
        guideMenuThree.SetActive(false);
        guideMenuFour.SetActive(false);
        }
}