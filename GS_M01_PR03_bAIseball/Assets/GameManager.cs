using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    PathFollower batter;
    RandomPosition ballPos;

    public Text text;
    private void Awake()
    {
        ballPos = FindObjectOfType<RandomPosition>();
        batter = FindObjectOfType<PathFollower>();
        text.text = "";
    }
    private void Start()
    {
        StartGame();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScene();
        }
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void StartGame()
    {
        batter.didHit = true;
        if (!ballPos.isBatting)
        {
            ballPos.isBatting = true;
        }
    }
}
