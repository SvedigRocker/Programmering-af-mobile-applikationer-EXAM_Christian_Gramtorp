using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Date : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI largeText;
    public TextMeshProUGUI moreLargeText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        string time = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy");
        // print(time);
        largeText.text = time;
        moreLargeText.text = time;
    }
}
