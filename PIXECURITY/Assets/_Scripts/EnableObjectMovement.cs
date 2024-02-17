using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnableObjectMovement : MonoBehaviour
{
    [SerializeField] bool isActive;
    [SerializeField] TextMeshProUGUI onOffText;

    ObjectManipulator manipulator;
    RotationAxisConstraint rotationAxisConstraint;

    // Start is called before the first frame update
    void Start()
    {
        manipulator = GetComponent<ObjectManipulator>();
        rotationAxisConstraint = GetComponent<RotationAxisConstraint>();
        //manipulator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveObject()
    {
        isActive = true;
        //manipulator.enabled = true;
        Debug.Log("J'active le manipulateur");
    }

    public void OnAndOffText()
    {
        if (isActive)
        {
            onOffText.text = "On";
        }
        else
        {
            onOffText.text = "Off";
        }
    }
}
