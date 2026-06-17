using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager gameManager = FindFirstObjectByType<GameManager>();

            if (gameManager != null)
            {
                gameManager.GameOver();
            }
        }
    }
}