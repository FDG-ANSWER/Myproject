using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject gameOverPanel;
    public GameObject winPanel;

    public TMP_Text messageText;
    public TMP_Text coreText;

    public int requiredEnergyCores = 1;

    private int collectedEnergyCores = 0;
    private bool gameOver = false;

    private static bool restartWithoutMenu = false;

    void Start()
    {
        gameOver = false;
        collectedEnergyCores = 0;

        if (messageText != null)
        {
            messageText.text = "";
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }

        if (winPanel != null)
        {
            winPanel.SetActive(false);
        }

        UpdateCoreText();

        string sceneName = SceneManager.GetActiveScene().name;

        if (mainMenuPanel != null)
        {
            if (sceneName == "Level01" && restartWithoutMenu == false)
            {
                mainMenuPanel.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                mainMenuPanel.SetActive(false);
                Time.timeScale = 1f;
            }
        }

        restartWithoutMenu = false;
    }

    public void StartGame()
    {
        if (mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(false);
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }

        if (winPanel != null)
        {
            winPanel.SetActive(false);
        }

        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        if (gameOver)
        {
            return;
        }

        gameOver = true;

        ShowMessage("You Died!");

        if (mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(false);
        }

        if (winPanel != null)
        {
            winPanel.SetActive(false);
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        restartWithoutMenu = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitToMenu()
    {
        restartWithoutMenu = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level01");
    }

    public void CollectEnergyCore()
    {
        collectedEnergyCores++;

        ShowMessage("Energy Core Collected!");
        UpdateCoreText();
    }

    public bool HasEnoughEnergyCores()
    {
        return collectedEnergyCores >= requiredEnergyCores;
    }

    public void TryOpenDoor()
    {
        if (HasEnoughEnergyCores())
        {
            WinGame();
        }
        else
        {
            ShowMessage("Need more Energy Cores!");
        }
    }

    public void WinGame()
    {
        ShowMessage("Level Complete!");

        if (mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(false);
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }

        if (winPanel != null)
        {
            winPanel.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;

        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "Level01")
        {
            SceneManager.LoadScene("Level02");
        }
        else if (sceneName == "Level02")
        {
            SceneManager.LoadScene("Level03");
        }
        else if (sceneName == "Level03")
        {
            SceneManager.LoadScene("Level04");
        }
        else if (sceneName == "Level04")
        {
            ShowMessage("You Finished All Levels!");
        }
    }

    private void UpdateCoreText()
    {
        if (coreText != null)
        {
            coreText.text = "Energy Cores: " + collectedEnergyCores + " / " + requiredEnergyCores;
        }
    }

    public void ShowMessage(string message)
    {
        if (messageText != null)
        {
            messageText.text = message;
        }
    }
}