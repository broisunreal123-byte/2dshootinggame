using Unity.VisualScripting;
using UnityEngine;

public class KeyMovement : MonoBehaviour
{
    [SerializeField] private float keyMovementSpeed = 2f;
    [SerializeField] private Transform Player;
    private bool touchKey = false;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            touchKey = true;
        }
    }
    void Update()
    {
        if (touchKey)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, keyMovementSpeed * Time.deltaTime);
        }
    }
}
