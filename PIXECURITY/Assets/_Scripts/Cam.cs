using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    //This script set the Main Camera's near clip plan to its minimum so the user can look closer at objects 
    void Start()
    {
       
        Camera.main.nearClipPlane = 0.01f;
    }
}
