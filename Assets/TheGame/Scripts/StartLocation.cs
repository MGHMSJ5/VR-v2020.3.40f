using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLocation : MonoBehaviour
{
    public Vector3 startLocation; //set the start location, Realtime.Instantite doesnt use Vector3
    //public GameObject good; //de empty gameobject with the 'good' objects
    //public GameObject bad; //de empty gameobject with the 'bad' objects

    public bool activateGood = false; //wil be activated if 'G' is pressed, from other script
    public bool activateBad = false; //wil be activated if 'B' is pressed
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startLocation; //set the location
    }

    private void Update()
    {
       // if (activateGood) //if 'G' is pressed
       // {
            //good.SetActive(true); //good gameobject will be enabled
       // }

        //if (activateBad) //if 'B' is pressed
       // {
            //bad.SetActive(true); 
        //}
    }
}
