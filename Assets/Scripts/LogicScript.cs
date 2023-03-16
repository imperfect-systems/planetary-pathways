using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    private int playerScore = 0;

    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private GameObject gameOverScreen;

    [SerializeField] private GameObject tutorialScreen;

    [SerializeField] private TextMeshProUGUI tutorialScreenText;

    [SerializeField] private ParticleSystem explosion;

    [SerializeField] private InputActionReference thrustAction;

    public void Start(){
        if(tutorialScreen){
            pauseGame();
            showTutorial();
        }
    }

    public void pauseGame(){
        Time.timeScale = 0; 
    }

    public void unPauseGame(){
        Time.timeScale = 1; 
    }

    public void addScore(int scoreToAdd){
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

    public void showTutorial(){
        string labelText = $"Press {thrustAction.action.GetBindingDisplayString()} to activate thrusters";
        tutorialScreenText.text = labelText;
    }
    public void dismissTutorial(){
        tutorialScreen.SetActive(false);
        unPauseGame();
    }

    public void loadScene(string name){
        SceneManager.LoadScene(name);
    }
    
    public void restartScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void quitGame(){
        loadScene("Main Menu");
    }

    public void exitGame(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}
