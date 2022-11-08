using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLocation : MonoBehaviour
{
    public Vector3 startLocation;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startLocation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
