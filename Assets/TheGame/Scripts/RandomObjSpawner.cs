using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjSpawner : MonoBehaviour
{
  public GameObject[] myObjects;

    MenuCode menuCode;
    [SerializeField] GameObject menuScript;

    private void Start()
    {
        menuCode = menuScript.GetComponent<MenuCode>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && menuCode.checkBool)
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

        Instantiate(myObjects[RandomIndex], randomSpawnPosition, Quaternion.identity);
    }
}
