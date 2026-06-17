using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    public float speed = 2f;
    public float leftX = -2f;
    public float rightX = 2f;

    private bool movingRight = true;

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            if (transform.position.x >= rightX)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            if (transform.position.x <= leftX)
            {
                movingRight = true;
                Flip();
            }
        }
    }

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager gameManager = FindObjectOfType<GameManager>();

            if (gameManager != null)
            {
                gameManager.GameOver();
            }
        }
    }
}