using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemensText : MonoBehaviour
{
 public Text demensText;
    // Start is called before the first frame update
    void Start()
    {
    demensText.text = "Demenskald: Bolig 7" + "\n" + "00:14";
    }
}
