using UnityEngine;
using TMPro;
public class CoinManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinAmountText;
    [SerializeField] private int amount;
    private int currentCoins = 0;
    public static CoinManager Instance;

    private void Awake()
    {
        Instance = this;
        UpdateCoinUI();
    }

    public void AddCoins()
    {
        currentCoins += amount;
        UpdateCoinUI();
    }

    private void UpdateCoinUI()
    {
        coinAmountText.text = currentCoins.ToString();
    }
}
