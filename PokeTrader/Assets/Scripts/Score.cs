using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class Score : MonoBehaviour
{
    private TextMeshProUGUI _scoreText;
    private int score;

    private void OnEnable()
    {
        Trader.TradeSuccessful += UpdateScore;
    }

    private void OnDisable()
    {
        Trader.TradeSuccessful -= UpdateScore;
    }

    private void Awake()
    {
        score = 0;
        _scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        _scoreText.text = $"Score: {score}";
    }

    private void UpdateScore()
    {
        score++;
        _scoreText.text = $"Score: {score}";
    }
}
