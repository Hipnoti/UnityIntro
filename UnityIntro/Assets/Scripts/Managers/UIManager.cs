using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        UpdateScore(0);
    }
    
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
