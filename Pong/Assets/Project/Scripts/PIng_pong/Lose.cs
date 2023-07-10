using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Lose : MonoBehaviour
{
    [SerializeField] Ball ball;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] private Transform BallPosition;

    private void OnCollisionEnter2D(Collision2D other)
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
        ball.BallSpeed = 0;
        BallPosition.position = Vector2.zero;
        yield return new WaitForSeconds(3);
        ball.BallSpeed = 5;

    }

}