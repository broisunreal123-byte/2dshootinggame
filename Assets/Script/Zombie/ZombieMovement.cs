using System;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float zombieSpeed;
    [SerializeField] private Rigidbody2D rb;
    void Update()
    {
        if (player == null) return;
        float direction = Math.Sign(player.position.x - transform.position.x);
        rb.linearVelocity = new Vector2(direction * zombieSpeed, rb.linearVelocity.y);
    }
}
