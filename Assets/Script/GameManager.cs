using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject startMenuUI;
    [SerializeField] private CharacterMovement player;
    void Update()
    {
        if (startMenuUI.activeSelf)
        {
            player.enabled = false;
        }
        else
        {
            player.enabled = true;
        }
    }

    
}
