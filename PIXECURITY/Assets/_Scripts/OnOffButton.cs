using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnOffButton : MonoBehaviour
{
    TextMeshPro onOffText;
    [SerializeField] bool isOn;
    void Start()
    {
        //Getting the TextMeshPro component
        onOffText = GetComponent<TextMeshPro>();
        //Set it to false on Start
        isOn = false;
        onOffText.text = "Off";
    }

    public void OnOffTextSwitch()
    {
        //This function is called OnClick and permits to display the text if the mode (Move/Rotate) is On or Off
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
