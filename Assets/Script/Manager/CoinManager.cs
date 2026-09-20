using UnityEngine;
using TMPro;
public class CoinManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinAmountText;
    [SerializeField] private int amount;
    [SerializeField] private  DatabaseManager db;
    private int currentCoins = 0;
    public static CoinManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
        UpdateCoinUI();
    }

    public void AddCoins()
    {
        currentCoins += amount;
        UpdateCoinUI();
        db.saveScore(currentCoins);
    }

    private void UpdateCoinUI()
    {
        coinAmountText.text = currentCoins.ToString();
    }
}
