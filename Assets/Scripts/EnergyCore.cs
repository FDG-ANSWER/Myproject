using UnityEngine;

public class EnergyCore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
        {
            return;
        }

        GameManager manager = FindFirstObjectByType<GameManager>();

        if (manager != null)
        {
            manager.CollectEnergyCore();
        }

        Destroy(gameObject);
    }
}