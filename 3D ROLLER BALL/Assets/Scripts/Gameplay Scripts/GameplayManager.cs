using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    
    public static GameplayManager instance;

    [SerializeField]
    private Text coinText, timerText;

    [SerializeField]
    private int coinCount =15;

    [SerializeField]
    private float timerThreshold = 150f;


    private float timerCount;

    private StringBuilder coinString = new StringBuilder(),timerString = new StringBuilder();

    private bool gameOver;

    [SerializeField]
    private GameObject gameOverPanel;

    private void Awake()
    {
        /*if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }*/

        instance = this;
        gameOverPanel.SetActive(false);
        timerCount = Time.time+1f;
        timerText.text = "Time: " + timerThreshold;
        coinText.text = "Coin: " + coinCount;
    }
    private void Update()
    {
        if (gameOver)
            return;

        CountTimer();

        if (timerThreshold == 0f || coinCount == 0)
        {
            GameOver();
        }
    }

    public void SetCoinCount(int coinValue)
    {
        coinCount += coinValue;

        coinString.Length = 0;
        coinString.Append("Coins: ");
        coinString.Append(coinCount.ToString());
        coinText.text = coinString.ToString();
    }
    void CountTimer()
    {
        if (Time.time > timerCount)
        {
            timerCount= Time.time+1f;
            timerThreshold--;

            timerString.Length = 0;
            timerString.Append("Time: ");
            timerString.Append(timerThreshold.ToString());
            timerText.text = timerString.ToString();
        }
    }


   
    public void GameOver()
    {
        gameOver = true;
        GameObject.FindWithTag(TagManager.PLAYER_TAG).GetComponent<BallController>().DestroyPlayer();
        Invoke("ShowGameOverPanel", 1f);
    }

    void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void Nextlevel()
    {
        SceneManager.LoadScene(0);
    }

}//class














































