using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLocation : MonoBehaviour
{
    public Vector3 startLocation;
    public GameObject good;
    public GameObject bad;

    public bool activateGood = false;
    public bool activateBad = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startLocation;
    }

    private void Update()
    {
        if (activateGood)
        {
            good.SetActive(true);
        }

        if (activateBad)
        {
            bad.SetActive(true);
        }
    }
}
