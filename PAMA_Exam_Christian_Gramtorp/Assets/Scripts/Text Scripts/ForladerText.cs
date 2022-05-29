using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForladerText : MonoBehaviour
{
public Text forladerText;
    // Start is called before the first frame update
    void Start()
    {
    forladerText.text = "Forlader rum: Bolig 36" + "\n" + "00:15";
    }
}
