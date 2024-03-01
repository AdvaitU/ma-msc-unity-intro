using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FottSteps : MonoBehaviour
{
    public AudioSource _fs;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) 
        {
            _fs.enabled = true;
        }
        else _fs.enabled = false;
    }
}
