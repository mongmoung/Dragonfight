using UnityEngine;
using UnityEngine.UI;

public class GameManager : SingleTone<GameManager>
{
    public Text scoreText;

    int score = 0;

    void Start()
    {
        scoreText.text = " ";
    }

    void Update()
    {
        
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score : " + score;
    }
}
