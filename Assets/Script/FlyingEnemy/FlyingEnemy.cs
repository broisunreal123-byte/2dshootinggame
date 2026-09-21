
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    private int direction = 1;
    [SerializeField] private float speed =  2f;
    void Update()
    {
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime,Space.World);
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("turningpoint"))
        {
            direction *= -1;
            transform.rotation = Quaternion.Euler(0, direction == 1 ? 0 : 180, 0);
        }
    }
}
