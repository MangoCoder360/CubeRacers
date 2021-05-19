using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour{
    public Transform player;
    public Text scoreText;
    int intScore;
    void Update()
    {
        scoreText.text = "Score: " + player.position.z.ToString("0");
        intScore = Mathf.RoundToInt(player.position.z);
        if (PlayerPrefs.GetInt("highScore",0) < intScore)
        {
            PlayerPrefs.SetInt("highScore", intScore);
            PlayerPrefs.Save();
        }
    }
}
