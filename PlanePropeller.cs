using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePropeller : MonoBehaviour
{
    private float propellerRotateSpeed=5f; // propeller rotate speed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotational motion
        transform.Rotate(Vector3.forward*propellerRotateSpeed); 
    }
}
