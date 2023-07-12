using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Lose : MonoBehaviour
{
    [SerializeField] private Ball ball;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private Transform BallPosition;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BlueZone"))
        {
            scoreManager.RedPlayerScore++;
            StartCoroutine(Wait());
        }
        if (other.gameObject.CompareTag("RedZone"))
        {
            scoreManager.BluePlayerScore++;
            StartCoroutine(Wait());
        }
    }
    public IEnumerator Wait()
    {
        GameManager.WhoWon.Invoke();
        UI.RefreshScore.Invoke(scoreManager.BluePlayerScore, scoreManager.RedPlayerScore);
        ball.BallSpeed = 0;
        BallPosition.position = Vector2.zero;
        yield return new WaitForSeconds(3);
        ball.BallSpeed = 5;


    }

}