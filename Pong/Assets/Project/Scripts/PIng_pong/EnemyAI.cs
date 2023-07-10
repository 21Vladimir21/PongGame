using System;
using System.Collections;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] private Transform player;
    [SerializeField] private Transform ball;
    private bool moveToBall;
    IEnumerator Start()
    {
        if (gameManager.TwoPlayers == true)
        {
            moveToBall = true;
            while (true)
            {
                yield return new WaitForSeconds(UnityEngine.Random.Range(3, 3.5f));
                moveToBall = !moveToBall;
            }
        }

    }
    void Update()
    {

        if (moveToBall && gameManager.TwoPlayers == true)
        {
            player.position = Vector3.Lerp(player.position, new Vector3(player.position.x, ball.position.y, player.position.z), 3 * Time.deltaTime);
        }

    }
}