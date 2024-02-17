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

    // Start is called before the first frame update
    void Start()
    {
        manipulator = GetComponent<ObjectManipulator>();
        rotationAxisConstraint = GetComponent<RotationAxisConstraint>();
        moveAxisConstraint = GetComponent<MoveAxisConstraint>();

        activeMovement = false;
        activeRotation = false;
        manipulator.enabled = false;
        rotationAxisConstraint.enabled = true;
        moveAxisConstraint.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnableMoveObject()
    {
        if (!activeMovement)
        {
            activeMovement = true;
            manipulator.enabled = true;
            moveAxisConstraint.enabled = false;
            Debug.Log("J'active le manipulateur, move object");
        }
        else
        {
            activeMovement = false;
            //manipulator.enabled = true;
            moveAxisConstraint.enabled = true;
            Debug.Log("Je désactive le manipulateur, stop move object");
        }
    }

    public void EnableRotationObject()
    {
        if (!activeRotation)
        {
            activeRotation = true;
            manipulator.enabled = true;
            rotationAxisConstraint.enabled = false;
        }
        else
        {
            activeRotation= false;
            rotationAxisConstraint.enabled= true;
        }
    }

}
