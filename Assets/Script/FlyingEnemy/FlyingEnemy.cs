
using Unity.VisualScripting;
using UnityEngine;

public class FlyingEnemy : Enemy
{
    private int direction = 1;
    [SerializeField] private float speed =  2f;
    [SerializeField] private GameObject fireball;
    [SerializeField] private Transform fireballspawnpoint;
    
    void Start()
    {
        
        dmg = 20;
        InvokeRepeating(nameof(spawnFireball), spawnCooldown, spawnCooldown - 0.5f);
    }
    void Update()
    {
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime,Space.World);
        
    }
    private void spawnFireball()
    {
        Instantiate(fireball, fireballspawnpoint.position,fireballspawnpoint.rotation);
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
