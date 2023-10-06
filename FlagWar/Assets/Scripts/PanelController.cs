using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour
{
    public GameObject LostPanel;
    public GameObject LevelPanel;
    public GameObject WinPanel;
    public void LostPanelControl()
    {
        LostPanel.SetActive(true);
    }
    public void LevelPanelControl()
    {
        LevelPanel.SetActive(true);
    }
    public void WinPanelControl()
    {
        WinPanel.SetActive(true);
    }
    public void Level2Button()
    {
        LevelPanel.SetActive(false);
        SceneManager.LoadScene(2);
    }
    public void RetryButton()
    {
        LostPanel.SetActive(false);
        SceneManager.LoadScene(1);
    }
    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }
}
