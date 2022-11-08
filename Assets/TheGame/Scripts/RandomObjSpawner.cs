using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class RandomObjSpawner : MonoBehaviour
{
    public GameObject[] myObjects;
    private string prefabName;

    public GameObject good;
    public GameObject bad;

    private int SpawnCounter = 0;

    MenuCode menuCode;
    [SerializeField] GameObject menuScript;

    StartLocation startLocation;

    private void Start()
    {
        menuCode = menuScript.GetComponent<MenuCode>();
    }

    void Update()
    {
        if (SpawnCounter < myObjects.Length)
        {
            if (Input.GetKeyDown(KeyCode.G) && menuCode.checkBool || Input.GetKeyDown(KeyCode.H) && menuCode.checkBool)
            //BNG.InputBridge.Instance.YButton
            {
                startLocation = myObjects[SpawnCounter].GetComponent<StartLocation>();
                prefabName = myObjects[SpawnCounter].name;
                startLocation.activateGood = true;
                Realtime.Instantiate(prefabName);
                SpawnCounter++;

            }

            if (Input.GetKeyDown(KeyCode.B) && menuCode.checkBool)
            //BNG.InputBridge.Instance.XButton
            {
                startLocation = myObjects[SpawnCounter].GetComponent<StartLocation>();
                prefabName = myObjects[SpawnCounter].name;
                startLocation.activateBad = true;
                Realtime.Instantiate(prefabName);
                SpawnCounter++;

            }
        }
        if (SpawnCounter + 1 > myObjects.Length)
        {
            Debug.Log("No spowning");
        }

    }


    //not used ↓
    public void SpawnGood()
    {

        good = myObjects[SpawnCounter].transform.GetChild(0).gameObject;
        good.SetActive(true);
    }

    public void SpawnBad()
    {

        bad = myObjects[SpawnCounter].transform.GetChild(1).gameObject;
        bad.SetActive(true);
    }
}
