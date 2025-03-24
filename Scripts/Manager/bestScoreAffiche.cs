using UnityEngine;
using TMPro; 

public class bestScoreAffiche : MonoBehaviour
{

public TextMeshProUGUI bestScoreText;

    void Start()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreText.text = "Meilleur Score: " + bestScore;
    }

}


