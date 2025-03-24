using TMPro; // Nécessaire pour utiliser TextMeshPro
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; 
    public int bestScore = 0;
    public TextMeshProUGUI scoreText; 
    public int pointLevel = 10;
    void Start()
    {
        UpdateScoreDisplay(); 
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
    }
    void Update()
    {
        if(score > pointLevel)
        {
            FindObjectOfType<ObjectSpawner>().AddLevel(-0.1f);
            Debug.LogWarning("AddSpeed Appellé");
            pointLevel += 8;
            Debug.LogWarning("Verife point score passé");
        }
    }
    public void AddPoints(int points)
    {
        score += points; 
        UpdateScoreDisplay();
        if (score > bestScore)
            {
                SaveBestScore();
            }
    }

    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score; 
    }

    public void SaveBestScore()
    {
            bestScore = score;
            PlayerPrefs.SetInt("BestScore", bestScore); 
            PlayerPrefs.Save(); 
            Debug.Log("Nouveau meilleur score enregistré : " + bestScore);
    }
}

