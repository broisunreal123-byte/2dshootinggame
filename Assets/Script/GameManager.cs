using Unity.VisualScripting;
using UnityEngine;

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
