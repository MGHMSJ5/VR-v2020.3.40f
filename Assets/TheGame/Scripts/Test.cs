using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject cube;

    //new
    MenuCode menuCode;
    [SerializeField] GameObject menuScript;
    // Start is called before the first frame update
    void Start()
    {
        menuCode = menuScript.GetComponent<MenuCode>();
    }

    // Update is called once per frame
    void Update()
    {
        if (menuCode.checkBool)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                cube.SetActive(true);
                Debug.Log("ooooooooooo");
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                cube.SetActive(false);
            }
        }

    }
}
