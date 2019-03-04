using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    static GameMaster instance;

    [SerializeField] GameObject MenuPanel;
    [SerializeField] GameObject GameUIPanel; 
    [SerializeField] GameObject GameOverPanel;

    private void Awake()
    {
        if (instance == null) instance = this;
        else this.enabled = false; 
    }

    public static void Play()
    {
        instance.GameUIPanel.SetActive(true);
        SpawnPoint.instance.SpawnBall(); 
    }

    public static void GameOver()
    {
        instance.GameUIPanel.SetActive(false);
        instance.GameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        instance.GameOverPanel.SetActive(false);
        Play(); 
    }
}
