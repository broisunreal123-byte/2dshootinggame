
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int dmg = 50;
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
            other.GetComponent<Character>().TakeDamage(dmg);
            Destroy(gameObject);
        }
        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }




}
