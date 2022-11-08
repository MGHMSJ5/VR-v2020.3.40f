using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class RandomObjSpawner : MonoBehaviour
{
    public GameObject[] myObjects;
    private string prefabName;

    MenuCode menuCode;
    [SerializeField] GameObject menuScript;

    private void Start()
    {
        menuCode = menuScript.GetComponent<MenuCode>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G) && menuCode.checkBool)
        //Input.GetKeyDown(KeyCode.Space)
        //BNG.InputBridge.Instance.YButton
        {
            SpawnObjects();
        }
    }

    public void SpawnObjects()
    {
        int RandomIndex = Random.Range(0, myObjects.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 0, Random.Range(-10, 11));
        prefabName = myObjects[RandomIndex].name;

        //Instantiate(myObjects[RandomIndex], randomSpawnPosition, Quaternion.identity);
        Realtime.Instantiate(prefabName);
    }
}
