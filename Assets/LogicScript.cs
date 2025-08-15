using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject titleScreen;
    

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
    public void startGame()
    {
        Time.timeScale = 1f;
        titleScreen.SetActive(false);
        
    }


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void titleScene()
    {
        Time.timeScale = 0f;
        titleScreen.SetActive(true);
    }
   


}
