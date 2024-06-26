using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    SceneFader fader;
    public GameObject Level2bg;
    public bool FirstLevel2;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(this);
    }
    private void Update()
    {
        if(!FirstLevel2&&Input.GetKeyDown(KeyCode.U))
        {
            FirstLevel2 = true;
            Level2bg.SetActive(true);
        }
    }
    public static void RegisterScnenFader(SceneFader obj)
    {
        instance.fader = obj;
    }

    public static void PlayerDied()
    {
        instance.fader.FadeOut();
        instance.Invoke("RestartScene", 0.8f);
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
