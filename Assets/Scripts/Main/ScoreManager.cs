using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;

    public Text scoreLabel;

    
    // Start is called before the first frame update
    void Start()
    {
        scoreLabel = GetComponent<Text>();
        scoreLabel.text = "Score:" + score;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreLabel.text = "Score:" + score;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
