using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public PlayerController playerController;
    public Text timeText;
    public Text coinText;
    public Text scoreText;
    public Text GamoverText;
    public Button RestartButton;

    float Timer=0;
    float count = 0;
    // Update is called once per frame
    void Update()
    {
        if (playerController.isDead)
        {
            count += Time.deltaTime;
            if (count < 4) return;
            scoreText.gameObject.SetActive(true);
            GamoverText.gameObject.SetActive(true);
            RestartButton.gameObject.SetActive(true);
        }
        else
        {
            Timer += Time.deltaTime;
            timeText.text = "TIME: " + (int)Timer;
            coinText.text = "Coins: " + playerController.CoinCount;
            int score = (int)Timer + playerController.CoinCount;
            scoreText.text = "Score: " + score;
            scoreText.gameObject.SetActive(false);
            GamoverText.gameObject.SetActive(false);
            RestartButton.gameObject.SetActive(false);
        }
        
    }
}
