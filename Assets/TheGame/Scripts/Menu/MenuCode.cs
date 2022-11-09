using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //to be able to change scenes in Unity
using UnityEngine.UI;

public class MenuCode : MonoBehaviour
{
    public int sceneNumber = 6; //the number of the next scene
    public GameObject BlacknessAppear; //image with black fading animation

    public Slider SoundSlider;
    public static float sliderValue = 0.5f;
    //new
    public static bool ifTherapist;
    public bool checkBool;

    public GameObject controlText;

    private void Start()
    {
        checkBool = ifTherapist;
        SoundSlider.value = sliderValue;
    }

    public void Update()
    {
        if (ifTherapist == false)
        {
            controlText.SetActive(false);
        }
    }

    //new
    public void PlayGameTherapist() //a function that'll be called whenever the 'Play'button is pressed
    {
        ifTherapist = true;
        sliderValue = SoundSlider.value;
        BlacknessAppear.SetActive(true); //activate the black appearing
        StartCoroutine(WaitForBlack()); //wait 1 sec (for the black to appear), then change scene

    }
    public void PlayGamePatient() //a function that'll be called whenever the 'Play'button is pressed
    {
        ifTherapist = false;
        sliderValue = SoundSlider.value;
        BlacknessAppear.SetActive(true); //activate the black appearing
        StartCoroutine(WaitForBlack()); //wait 1 sec (for the black to appear), then change scene

    }

    public void PlayGame() //a function that'll be called whenever the 'Play'button is pressed
    {
        sliderValue = SoundSlider.value;
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
        AudioListener.volume = SoundSlider.value;
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
        Time.timeScale = 1f;
    }
}
