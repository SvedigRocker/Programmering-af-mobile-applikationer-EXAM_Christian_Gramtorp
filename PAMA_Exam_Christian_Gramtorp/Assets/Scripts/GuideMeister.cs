using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuideMeister : MonoBehaviour
{
    [SerializeField] GameObject guideMenu;

    public void Guider()
    {

    guideMenu.SetActive(true);
    
    }

   
    public void Resumer()
    {

    guideMenu.SetActive(false);

    }
}