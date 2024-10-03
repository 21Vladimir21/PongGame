using System.Collections;
using System.Collections.Generic;
using Kimicu.YandexGames;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] Transform ballPosition;

    [SerializeField] private GameObject PingPong;
    [SerializeField] private GameObject PingPongPanel;
    [SerializeField] private GameObject BlueWinPanel;
    [SerializeField] private GameObject RedWinPanel;
    [SerializeField] private GameObject PongUi;
    [SerializeField] private GameObject HelpInfoAi;

    [SerializeField] private Button backToMenuButton;

    public bool EnemyAi = false;


    public static UnityEvent WhoWon = new UnityEvent();

    private void Awake()
    {
        WhoWon.AddListener(WhoWonPong);
        backToMenuButton.onClick.AddListener(BackToMenu);
    }

    private void WhoWonPong()
    {
        if (scoreManager.BluePlayerScore >= 5)
            WinScreens(true);

        if (scoreManager.RedPlayerScore >= 5)
            WinScreens(false);
    }

    private void ResetScore()
    {
        scoreManager.BluePlayerScore = 0;
        scoreManager.RedPlayerScore = 0;
    }

    private void WinScreens(bool blueWin)
    {
        if (!blueWin)
            RedWinPanel.SetActive(true);
        if (blueWin)
            BlueWinPanel.SetActive(true);
        
        backToMenuButton.gameObject.SetActive(true);
        
        
    }

    public void BackToMenu()
    {
        if (Advertisement.AdvertisementIsAvailable)
            Advertisement.ShowInterstitialAd(onCloseCallback: EndLevel);
        else
            EndLevel();
    }

    private void EndLevel()
    {
        backToMenuButton.gameObject.SetActive(false);
        ResetScore();
        PingPong.SetActive(false);
        PingPongPanel.SetActive(true);
        RedWinPanel.SetActive(false);
        BlueWinPanel.SetActive(false);
        PongUi.SetActive(false);
        UI.RefreshScore.Invoke(scoreManager.BluePlayerScore, scoreManager.RedPlayerScore);
        ballPosition.position = Vector2.zero;
        
    }

    public void PlayButton(bool enemyAi)
    {
        if (enemyAi)
            HelpInfoAi.SetActive(false);
        else
            HelpInfoAi.SetActive(true);

        EnemyAi = enemyAi;
        PingPongPanel.SetActive(false);
        PingPong.SetActive(true);
        PongUi.SetActive(true);
    }
}