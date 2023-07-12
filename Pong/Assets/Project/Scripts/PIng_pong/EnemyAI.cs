using System.Collections;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    [SerializeField] private GameManager gameManager;
    [SerializeField] private Rigidbody2D redPlayerRb;
    [SerializeField] private Transform ball;
    private float MoveSpeed = 3;
    private bool AllowedToMove = false;
    IEnumerator Start()
    {
        if (gameManager.EnemyAi == true)
        {
            AllowedToMove = false;
            while (true)
            {
                Debug.Log("вошел в цикл" + AllowedToMove);
                yield return new WaitForSeconds((Random.Range(3f, 5f)));

                AllowedToMove = !AllowedToMove;
                Debug.Log(" вышел из цикл цикла" + AllowedToMove);
            }
        }
    }

    private void FixedUpdate()
    {

        if (AllowedToMove && gameManager.EnemyAi)
        {
            if (ball.position.y > redPlayerRb.position.y)
                redPlayerRb.velocity = Vector2.up.normalized * MoveSpeed;
            else
                redPlayerRb.velocity = Vector2.down.normalized * MoveSpeed;
        }
    }
}