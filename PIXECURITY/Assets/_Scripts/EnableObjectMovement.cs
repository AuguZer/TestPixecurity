using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObjectMovement : MonoBehaviour
{
    [SerializeField] bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveObject()
    {
        isActive = true;
        Debug.Log("Je click et cette fonction se lance");
    }
}
