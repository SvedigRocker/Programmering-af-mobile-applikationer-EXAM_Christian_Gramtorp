using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MyTabs : MonoBehaviour
{
    public GameObject tabbutton1;
    public GameObject tabbutton2;
  
    public GameObject tabcontent1;
    public GameObject tabcontent2;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HideAllTabs()
    {
        //gør alle tabcontens inactive
        tabcontent1.SetActive(true);
        tabcontent2.SetActive(false);


        //skifter farven på de inactive Tabbuutons når de er inactive.
        tabbutton1.GetComponent<Button>().image.color = new Color32(128, 213, 244, 150);
        tabbutton2.GetComponent<Button>().image.color = new Color32(128, 213, 244, 150);

    }
    public void ShowTab1()
    {
        //activer tabcontent 1 og higlighter farven
        HideAllTabs();
        tabcontent1.SetActive(true);
        tabbutton1.GetComponent<Button>().image.color = new Color32(128, 213, 244, 255);

    }
    public void ShowTab2()
    {
        //activer tabcontent 2 og higlighter farven
        HideAllTabs();
        tabcontent2.SetActive(true);
        tabbutton2.GetComponent<Button>().image.color = new Color32(128, 213, 244, 255);

    }


    //en funktion der gør at hver gang man trykker på dem slår de bool værdien
    //tab1 til eller fra tab 1 skal sættte

}
