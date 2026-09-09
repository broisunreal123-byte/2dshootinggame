using UnityEngine;

public class ZombieHitbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameManagerMap2.Instance.showLoseMenu();
        }
    }
}
