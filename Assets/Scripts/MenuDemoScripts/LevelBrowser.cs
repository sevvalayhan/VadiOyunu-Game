using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBrowser : MonoBehaviour
{

    public LevelButton[] levelButtons;
    public GameObject buttonParent;
    public GameObject mainMenu;
    private void OnEnable()
    {
        for (int i = 0; i < GameManager.Instance.levelCounts[GameManager.Instance.currentWorld ]; i++)
        {
            int levelNum = i + 1;
            levelButtons[i].gameObject.SetActive(true);
            levelButtons[i].levelText.text = (i + 1).ToString();
            levelButtons[i].GetComponent<Button>().onClick.RemoveAllListeners();
            levelButtons[i].GetComponent<Button>().onClick.AddListener(() => SelectLevel(GameManager.Instance.currentWorld, levelNum));
        }

    }


    private void SelectLevel(int world, int level)
    {
        Debug.Log("Loaded level" + world + " - " + level);
    }

    public void BackButton()
    {
        mainMenu.SetActive(true);
        foreach (LevelButton l in levelButtons)
        {
            l.gameObject.SetActive(false);
        }
        this.gameObject.SetActive(false);
    }
}
