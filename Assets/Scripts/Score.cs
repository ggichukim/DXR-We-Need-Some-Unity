using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreUI;

    private int HitScore = 50;

    // Start is called before the first frame update
    void Start()
    {
        scoreUI.text = "Score: 0";
    }

    public void AddScore()
    {
        score = score + HitScore;
        scoreUI.text = "Score: " + score.ToString();
    }
}
