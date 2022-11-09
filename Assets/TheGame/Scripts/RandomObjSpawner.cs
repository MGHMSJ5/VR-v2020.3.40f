using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class RandomObjSpawner : MonoBehaviour
{
    public GameObject[] myObjects; //list with all the Spawners
    private string prefabName; //ame of the selected prefab in the spawners

    public GameObject good;
    public GameObject bad;

    private int SpawnCounter = 0; //will be used to select the gameobjects in the list

    MenuCode menuCode; //wil be the menu script
    [SerializeField] GameObject menuScript; //the gameobject with the menuscript

    StartLocation startLocation; //will be the script from the gameobject from the list

    public GameObject finishedText; //will be the 'finished' text when everything is spawned

    private void Start()
    {
        menuCode = menuScript.GetComponent<MenuCode>(); //get the menu script
    }

    void Update()
    {
        if (SpawnCounter < myObjects.Length)
        {
            if (Input.GetKeyDown(KeyCode.G) && menuCode.checkBool || BNG.InputBridge.Instance.YButton && menuCode.checkBool) 
                //if 'G' is pressed, and you selected therapist in menu / pressed Y on VR controller and selected therapist
            //BNG.InputBridge.Instance.YButton
            {
                startLocation = myObjects[SpawnCounter].GetComponent<StartLocation>();//get the script
                prefabName = myObjects[SpawnCounter].name;//get the name of the prefab
                startLocation.activateGood = true; //enable the 'good' empty gameobject
                Realtime.Instantiate(prefabName); //instantate
                SpawnCounter++; //go to next prefab in list

            }
            //↓ the following if is the same as the previous one, but for spawning the 'bad' props
            if (Input.GetKeyDown(KeyCode.B) && menuCode.checkBool || BNG.InputBridge.Instance.XButton && menuCode.checkBool)
            //BNG.InputBridge.Instance.XButton
            {
                startLocation = myObjects[SpawnCounter].GetComponent<StartLocation>();
                prefabName = myObjects[SpawnCounter].name;
                startLocation.activateBad = true;
                Realtime.Instantiate(prefabName);
                SpawnCounter++;

            }
        }
        if (SpawnCounter == myObjects.Length) //if you have spawned the last prefab in the list
        {
            finishedText.SetActive(true); //make 'Finished!' text appear
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
