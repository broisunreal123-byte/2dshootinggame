
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnEnable()
    {
        rb.linearVelocity = Vector2.down * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            if (other == null) return;
        }
        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }


   
    
}
