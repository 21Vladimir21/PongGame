using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class RedPlayerMove : MoveLogic
{
    [SerializeField] GameManager gameManager;
    override public void Move()
    {
        if (gameManager.EnemyAi == false)
        {
            if (Input.GetKey(KeyCode.P))
                PlayerRb.velocity = Vector2.up * PlayerSpeed;
            else
                PlayerRb.velocity = Vector2.down * PlayerSpeed;
        }

    }

    override public void MobileMoveUp()
    {
        if (gameManager.EnemyAi == false)
            PlayerRb.velocity = Vector2.down * PlayerSpeed;
    }
    override public void MobileMoveDown()
    {
        if (gameManager.EnemyAi == false)
            PlayerRb.velocity = Vector2.up * PlayerSpeed;
    }
}