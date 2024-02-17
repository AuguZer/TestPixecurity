using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnOffButton : MonoBehaviour
{
    TextMeshPro onOffText;
    [SerializeField] bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        //Getting the TextMeshPro component
        onOffText = GetComponent<TextMeshPro>();
        //Set it to false on Start
        isOn = false;
        onOffText.text = "Off";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnOffTextSwitch()
    {
        //This function is called OnClick and permits to display the text if the mode is On or Off
        if (!isOn)
        {
            isOn = true;
            onOffText.text = "On";
        }
        else
        {
            isOn = false;
            onOffText.text = "Off";
        }
    }

}
