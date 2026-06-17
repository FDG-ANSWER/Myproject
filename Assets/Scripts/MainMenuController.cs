using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject readmePanel;

    public void StartGame()
    {
        SceneManager.LoadScene("Level01");
    }

    public void ShowReadme()
    {
        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(false);

        if (readmePanel != null)
            readmePanel.SetActive(true);
    }

    public void HideReadme()
    {
        if (readmePanel != null)
            readmePanel.SetActive(false);

        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}