using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    private Vector3 cameraTarget;
    private Transform target;
    
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        cameraTarget = transform.position - target.transform.position;

    }
	
	void Update () {
        transform.position = target.transform.position + cameraTarget;
    }
}
