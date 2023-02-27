using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject levelBrowser;

    public void ShowLevels(int word)
    {
        GameManager.Instance.currentWorld = word;
        levelBrowser.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
