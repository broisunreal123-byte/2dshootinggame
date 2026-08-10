using Unity.VisualScripting;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Key"))
        {
            Destroy(other.gameObject); 
        }
            
        
    }
}
