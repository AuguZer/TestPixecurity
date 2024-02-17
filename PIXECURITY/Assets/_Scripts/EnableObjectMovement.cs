using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnableObjectMovement : MonoBehaviour
{
    [SerializeField] bool activeMovement;
    [SerializeField] bool activeRotation;

    ObjectManipulator manipulator;
    RotationAxisConstraint rotationAxisConstraint;
    MoveAxisConstraint moveAxisConstraint;

    void Start()
    {
        //Getting all the component we need
        //Manipulator
        manipulator = GetComponent<ObjectManipulator>();
        //Rotation constraint
        rotationAxisConstraint = GetComponent<RotationAxisConstraint>();
        //Movement constraint
        moveAxisConstraint = GetComponent<MoveAxisConstraint>();

        //Setting booleans and the manipulator to false in start so the user needs to click on a button to manipulate objects
        activeMovement = false;
        activeRotation = false;
        manipulator.enabled = false;

        //Freezing the object so the user needs to click on a button to disable those constraints
        rotationAxisConstraint.enabled = true;
        moveAxisConstraint.enabled = true;
    }
    public void EnableMoveObject()
    {
        //Function that enable to move the object 
        //Function called on the Onclick event of the First Button
        if (!activeMovement) // If the button is off, it turns "On" when we click, this enable the user to move the object
        {
            activeMovement = true;
            manipulator.enabled = true;
            moveAxisConstraint.enabled = false;
            Debug.Log("J'active le manipulateur, Move object is ON");
        }
        else //If the button is on, it turns "Off" when we click, the user can't move the object
        {
            activeMovement = false;
            //manipulator.enabled = true;
            moveAxisConstraint.enabled = true;
            Debug.Log("Move object is OFF");
        }
    }

    public void EnableRotationObject()
    {
        //Function that enable to rotate the object 
        //Function called on the Onclick event of the Second Button
        if (!activeRotation) // If the button is off, it turns "On" when we click, this enable the user to rotate the object from its center
        {
            activeRotation = true;
            manipulator.enabled = true;
            rotationAxisConstraint.enabled = false;

            Debug.Log("J'active le manipulateur, Rotate object is ON");
        }
        else //If the button is on, it turns "Off" when we click, the user can't rotate the object
        {
            activeRotation= false;
            rotationAxisConstraint.enabled= true;
            Debug.Log("Rotate object is OFF");
        }
    }

    //IF BOTH BUTTON "MOVE OBJECT" and "ROTATE OBJECT" are ON, the user can move and rotate the object.

}
