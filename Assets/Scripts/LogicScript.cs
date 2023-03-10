using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    private int playerScore = 0;

    [SerializeField]
    private TextMeshPro scoreText;

    [SerializeField]
    private GameObject gameOverScreen;

    public void addScore(int scoreToAdd){
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

    public void restartScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
