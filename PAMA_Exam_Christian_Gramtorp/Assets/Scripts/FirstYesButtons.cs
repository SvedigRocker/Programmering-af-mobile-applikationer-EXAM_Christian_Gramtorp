using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstYesButtons : MonoBehaviour
{
    [SerializeField] GameObject guideMenu;
    [SerializeField] GameObject guideMenuTwo;
    [SerializeField] GameObject guideMenuThree;
    [SerializeField] GameObject guideMenuFour;


    public void Closer()
    {
    
        guideMenu.SetActive(false);
        guideMenuTwo.SetActive(false);
        guideMenuThree.SetActive(false);

    }
}
