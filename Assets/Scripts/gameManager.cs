using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public bool gameStarted { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        StartGame();   
    }

    public void StartGame()
    {
        gameStarted = true;
    }

    public void RestartGame()
    {
        Invoke("Load", 1f);
    }

    private void Load()
    {
        SceneManager.LoadScene(0);
    }
}
