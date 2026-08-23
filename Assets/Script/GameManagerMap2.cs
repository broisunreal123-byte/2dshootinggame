using Unity.VisualScripting;
using UnityEngine;

public class GameManagerMap2 : MonoBehaviour
{
    [SerializeField] private GameObject EndMenuUI;
    void Start()
    {
        EndMenuUI.SetActive(false);
    }

    
}
