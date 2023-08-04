using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane; // the player's object
    private Vector3 offset = new Vector3(17.59f,1.47f,1.43f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // move the camera away from the player
        transform.position = plane.transform.position + offset; 
    }
}
