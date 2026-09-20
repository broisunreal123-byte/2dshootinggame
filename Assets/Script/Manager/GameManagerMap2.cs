using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMap2 : MonoBehaviour
{
    [SerializeField] private GameObject WinMenuUI;
    [SerializeField] private GameObject LoseMenuUI;
    [SerializeField] private String StartScene = "SampleScene";
    public static GameManagerMap2 Instance;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        WinMenuUI.SetActive(false);
        LoseMenuUI.SetActive(false);
    }
    public void replayScene()
    {
        Time.timeScale = 1f;
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
    public void firstGameScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(StartScene);
    }
    public void showLoseMenu()
    {
        LoseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    
}
