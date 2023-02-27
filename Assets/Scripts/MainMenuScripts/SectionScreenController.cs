using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionScreenController : MonoBehaviour
{
    public GameObject SaplashScreen;
    public GameObject CategoryScreen;
    public GameObject Turkce_LevelsPanel;
    public GameObject Matematik_LevelsPanel;
    public void PlayGameButton()
    {
        SaplashScreen.SetActive(false);
        CategoryScreen.SetActive(true);

    }
    public void OpenTurkceLevelsButton()
    {
        CategoryScreen.SetActive(false);
        Turkce_LevelsPanel.SetActive(true);
    }
    public void OpenMatematikLevelsButton()
    {
        CategoryScreen.SetActive(false);
        Matematik_LevelsPanel.SetActive(true);
    }

    public void BackToMainMenu()
    {        
        CategoryScreen.gameObject.SetActive(true);
        Turkce_LevelsPanel.gameObject.SetActive(false);
        Matematik_LevelsPanel.gameObject.SetActive(false);
    }
}
