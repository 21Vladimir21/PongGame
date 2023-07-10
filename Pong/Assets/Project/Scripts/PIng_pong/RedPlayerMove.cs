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
        if (gameManager.TwoPlayers == false)
        {
            if (Input.GetKey(KeyCode.M))
                PlayerRb.velocity = Vector2.up * PlayerSpeed;
            else
                PlayerRb.velocity = Vector2.down * PlayerSpeed;
        }

    }
}