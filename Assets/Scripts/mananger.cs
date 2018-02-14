using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mananger : MonoBehaviour {
    
    
    
    public GameObject gameOverText;
    public bool gameOver;
    public int score, vidas;
    public Text ScoreText, livesText;
	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
        vidas = 3;
        gameOver = false;
        
        gameOverText.SetActive(false);
        ScoreText.gameObject.SetActive(true);
    }
    public void LoseScore(int value)
    {
        score -= value;
        UpdateScore();
    }
    public void AddScore (int value)
    {
        score += value;
        UpdateScore();
    }
    public void Addlives(int value)
    {
        vidas += value;
        UpdateScore();
    }
    // Update is called once per frame
    void Update () {
		if (gameOver)
        {
            GameOver();
        }
	}

    void UpdateVidas()
    {
        livesText.text = "" + vidas;
    }
    void UpdateScore()
    {
        ScoreText.text = "" + score;
    }

    public void GameOver() //esto hace aparecer el menú de perder
    {
        gameOverText.SetActive(true);
        
    }
}
