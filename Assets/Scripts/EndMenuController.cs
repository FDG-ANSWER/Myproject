using UnityEngine;

public class EndMenuController : MonoBehaviour
{
    public GameObject completePanel;
    public GameObject storyPanel;

    public void ShowStoryPanel()
    {
        completePanel.SetActive(false);
        storyPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game");

        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}