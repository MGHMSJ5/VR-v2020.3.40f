using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLocation : MonoBehaviour
{
    private Vector3 spawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = new Vector3(0, 0, 0);
        transform.position = spawnLocation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
