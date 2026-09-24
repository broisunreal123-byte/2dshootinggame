using System;
using Unity.VisualScripting;
using UnityEngine;

public class Zombie : Enemy
{
    [SerializeField] private Transform player;
    [SerializeField] private float zombieSpeed;
    [SerializeField] private Rigidbody2D rb;
    void Start()
    {
        dmg = 20;
    }
    void Update()
    {
        if (player == null) return;
        float direction = Math.Sign(player.position.x - transform.position.x);
        rb.linearVelocity = new Vector2(direction * zombieSpeed, rb.linearVelocity.y);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Character playercharacter = other.GetComponent<Character>();
            if (Time.time >= lastAttack + spawnCooldown)
            {
                playercharacter.TakeDamage(dmg);
                lastAttack = Time.time;
            }
            
        }
    }
}
