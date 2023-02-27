using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScreenController : MonoBehaviour
{
    public GameObject SplashScreen;
    public GameObject GameScreen;
    public GameObject nextButton;
    public GameObject FinishScreen;
    public GameObject[] Levels;
    public Animator Loading;
    public int currentLevel;
    public int newLevel;

    public void StartButton()
    {
        SplashScreen.SetActive(false);
        
        Debug.Log("tiklandi");
        GameScreen.SetActive(true);
    }

    /*public void OpenLoadingScreen()
    {
        GameScreen.SetActive(false);
        LoadingScreen.SetActive(true);
    }*/



    public void NextLevelButton()
    {
        if (currentLevel < Levels.Length && currentLevel != Levels.Length - 1)
        {
            Loading.Play("LoadingScreenOpen");
            nextButton.SetActive(false);

        }
        else
        {
            Levels[newLevel].SetActive(false);
            FinishScreen.SetActive(true);
            currentLevel = 0;
        }

    }
    public void ChangeLevelButton()
    {
        if (currentLevel < Levels.Length)
        {
            Loading.Play("LoadingScreenClosed");
            Levels[currentLevel].SetActive(false);
            currentLevel++;
            newLevel = currentLevel;
            Levels[newLevel].SetActive(true);
            nextButton.SetActive(false);


        }
        else
        {
            FinishScreen.SetActive(true);

        }
    }


    public void Reset()
    {
        SceneManager.LoadScene("GameScene");

        //GameScreen.SetActive(false);
        //FinishScreen.SetActive(false);
        //SplashScreen.SetActive(true);
        //currentLevel = 0;
        //Levels[currentLevel].SetActive(true);

    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
