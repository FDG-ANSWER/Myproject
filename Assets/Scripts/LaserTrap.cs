using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager manager = FindFirstObjectByType<GameManager>();

            if (manager != null)
            {
                manager.GameOver();
            }
        }
    }
}