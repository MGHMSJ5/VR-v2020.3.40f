using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLocation : MonoBehaviour
{
    public Vector3 startLocation; //set the start location, Realtime.Instantite doesnt use Vector3

    void Start()
    {
        transform.position = startLocation; //set the location
    }

}
