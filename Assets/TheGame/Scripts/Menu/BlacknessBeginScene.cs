using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlacknessBeginScene : MonoBehaviour
{

    //When the scene starts, the black image will dissappear.
    //But the GameObject is still active in the scene. With this short code it'll deactivate itseld when the animation is dene
    void Start()
    {
        StartCoroutine(BlackGone());
    }

    IEnumerator BlackGone()
    {
        yield return new WaitForSeconds(1);
        this.gameObject.SetActive(false);
    }
}
