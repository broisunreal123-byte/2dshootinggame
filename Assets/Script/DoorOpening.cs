using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpening : MonoBehaviour
{
    [SerializeField] private String nextScene = "Map2";
    private bool isUnlocked = false;
    public void Unlock()
    {
        isUnlocked = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Key"))
        {
            Unlock();
            Debug.Log("Door Unlocked: " + isUnlocked);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Player") && isUnlocked)
        {
            SceneManager.LoadScene(nextScene);
            Debug.Log("Loading");
        }
            
        
    }
}
