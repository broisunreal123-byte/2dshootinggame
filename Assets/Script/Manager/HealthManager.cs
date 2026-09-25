using UnityEngine;
using TMPro;
public class HealthManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthAmount;
     public static HealthManager Instance;
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
            return;
        }
    }
    public void UpdateHealthUI(int currenthp)
    {
      healthAmount.text = currenthp.ToString();  
    }
}
