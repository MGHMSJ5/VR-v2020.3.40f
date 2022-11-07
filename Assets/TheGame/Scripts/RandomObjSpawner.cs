using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class RandomObjSpawner : MonoBehaviour
{
  public GameObject[] myObjects;
    private string cubeName;
    
    private void Start()
    {
       
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        //Input.GetKeyDown(KeyCode.Space)
        //BNG.InputBridge.Instance.YButton
        {
            SpawnObjects();
        }
    }

    [System.Obsolete]
    public void SpawnObjects()
    {
        int RandomIndex = Random.Range(0, myObjects.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 0, Random.Range(-10, 11));
        cubeName = myObjects[RandomIndex].name;

        //Instantiate(myObjects[RandomIndex], randomSpawnPosition, Quaternion.identity);
        Realtime.Instantiate(cubeName);
    }
}
