using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour {

    private void Start()
    {
        
    }

    private void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W");
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
        }

        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log("C");
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("LeftShift");
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.D))
        {
            Debug.Log("LeftControl");
        }
    }
}
