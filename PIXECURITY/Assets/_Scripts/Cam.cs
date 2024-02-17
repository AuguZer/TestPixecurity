using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.nearClipPlane = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
