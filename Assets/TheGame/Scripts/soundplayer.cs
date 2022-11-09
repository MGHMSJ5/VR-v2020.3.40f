using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundplayer : MonoBehaviour
{
    public AudioSource soundPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.B)|| BNG.InputBridge.Instance.XButton )
        {
            soundPlayer.Play();
        }
    }
    public void playsad()
    {
       
    }
}
