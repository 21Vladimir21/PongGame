using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] private Rigidbody2D BallRb;
    [SerializeField] public float BallSpeed = 9;
    private Vector2 direction;

    private void OnEnable()
    {
        BallSpeed = 9;
        SetTheDirection();
    }

    private void FixedUpdate()
    {
        StartCoroutine(BallMove());
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            direction.x = -direction.x;
        else if (other.gameObject.CompareTag("Wall"))
            direction.y = -direction.y;
    }

    public void SetTheDirection()
    {
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));
    }
    public IEnumerator BallMove()
    {
        yield return new WaitForSeconds(3);
        BallRb.velocity = direction.normalized * BallSpeed;
    }
}

