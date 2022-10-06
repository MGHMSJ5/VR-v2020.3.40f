using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjSpawner : MonoBehaviour
{
  public GameObject[] myObjects;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        //Input.GetKeyDown(KeyCode.Space)
        //BNG.InputBridge.Instance.YButton
        {
            SpawnObjects();
        }
    }

    public void SpawnObjects()
    {
        int RandomIndex = Random.Range(0, myObjects.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 1, Random.Range(-10, 11));

        Instantiate(myObjects[RandomIndex], randomSpawnPosition, Quaternion.identity);
    }
}
