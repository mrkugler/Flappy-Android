using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public Text scoreText;
    public int currentScore;
    public AudioSource scoreSound;

    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void FindScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        scoreText.text = "" + currentScore;
        scoreSound.Play();
    }

}
