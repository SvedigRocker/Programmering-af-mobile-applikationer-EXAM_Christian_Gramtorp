using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaldText : MonoBehaviour
{
public Text faldText;
    // Start is called before the first frame update
    void Start()
    {
    faldText.text = "Faldalarm: Bolig 13" + "\n" + "00:07";
    }
}
