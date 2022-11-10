using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //to be able to change scenes in Unity
using UnityEngine.UI; //add this to be able to change UI

public class MenuCode : MonoBehaviour
{
    public int sceneNumber = 6; //the number of the next scene
    public GameObject BlacknessAppear; //image with black fading animation

    public Slider SoundSlider; //this will be the slider
    public static float sliderValue = 0.5f; //this will be used to set the value of the slider. Is static so that the value won't change when changing scenes

    public static bool ifTherapist; //will be used to see if the player selected therapist. Is static so that the value won't change when changing scenes
    public bool checkBool; //will be used as ifTherapist in the other script. Becasue ifTherapist can't be used

    public GameObject controlText; //the text with an explination of the controlls

    private void Start()
    {
        checkBool = ifTherapist; //set the bool
        SoundSlider.value = sliderValue; //set the value of the slider
    }

    public void Update()
    {
        if (ifTherapist == false) //if the player didn't click on the therapist, but on the Client
        {
            controlText.SetActive(false); //the controls text will be disableds
        }
    }

    public void PlayGamePatient() //a function that'll be called whenever the 'Play'button is pressed
    {
        ifTherapist = false; //the player is the Client. the client can't spawn objects
        sliderValue = SoundSlider.value; //if the value of the slider changed, then the float will also change. Will be the same in the next scene

        BlacknessAppear.SetActive(true); //activate the black appearing
        StartCoroutine(WaitForBlack()); //wait 1 sec (for the black to appear), then change scene

    }
    
    public void PlayGameTherapist() //a function that'll be called whenever the 'Play'button is pressed
    {
        ifTherapist = true; //the player clicked the therapist. This bool will be used in the spawn scipt
    sliderValue = SoundSlider.value; //if the value of the slider changed, then the float will also change. Will be the same in the next scene

        BlacknessAppear.SetActive(true); //activate the black appearing
        StartCoroutine(WaitForBlack()); //wait 1 sec (for the black to appear), then change scene

    }
    public void PlayGame() //a function that'll be called whenever the 'Play'button is pressed
    {
        //sliderValue = SoundSlider.value;
        BlacknessAppear.SetActive(true); //activate the black appearing
        StartCoroutine(WaitForBlack()); //wait 1 sec (for the black to appear), then change scene

    }

    public void ExitGame() // a function that'll be calld whenever the 'Exit' button is pressed
    {
        sliderValue = SoundSlider.value;
        BlacknessAppear.SetActive(true); //activate the black appearing
        StartCoroutine(WaitForBlackExit());
    }
    public void QuitGame() //a funciton that'll be called when the 'Quit' button is pressed
    {
        Debug.Log("QuitGame"); //to see if it works
        Application.Quit(); //Quit the game
    }

    public void ChangeSound()
    {
        AudioListener.volume = SoundSlider.value; //change the volume
    }


    IEnumerator WaitForBlack()
    {
        yield return new WaitForSeconds(1); //wait 1 second
        SceneManager.LoadScene(sceneNumber); //go to the next scene that is in the queue (In Build Settings).
    }

    IEnumerator WaitForBlackExit()
    {
        yield return new WaitForSeconds(1); //wait 1 second
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //go to the previous scene that is in the queue (In Build Settings).
    }
}
