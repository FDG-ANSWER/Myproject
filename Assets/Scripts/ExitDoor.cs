using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager gameManager = FindFirstObjectByType<GameManager>();

            if (gameManager != null)
            {
                gameManager.TryOpenDoor();
            }
        }
    }
}