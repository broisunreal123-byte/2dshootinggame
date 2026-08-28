using UnityEngine;

public class ZombieKHitbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            GameManagerMap2.Instance.showLoseMenu();
        }
    }
}
