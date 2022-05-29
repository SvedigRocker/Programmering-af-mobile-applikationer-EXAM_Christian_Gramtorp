using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGuideMeister : MonoBehaviour

{
    [SerializeField] GameObject guideMenuTwo;
  


    public void Nexter()
    {

    guideMenuTwo.SetActive(true);
    
    }

   
    public void Backer()
    {
    
    guideMenuTwo.SetActive(false);

    }
}
