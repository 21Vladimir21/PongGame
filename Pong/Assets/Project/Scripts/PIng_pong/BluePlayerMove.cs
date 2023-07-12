using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class BluePlayerMove : MoveLogic
{
    override public void Move()
    {
        if (Input.GetKey(KeyCode.Z))
            PlayerRb.velocity = Vector2.up * PlayerSpeed;
        else
            PlayerRb.velocity = Vector2.down * PlayerSpeed;
    }

    override public void MobileMoveUp()
    {
        PlayerRb.velocity = Vector2.down * PlayerSpeed;
    }

    override public void MobileMoveDown()
    {
        PlayerRb.velocity = Vector2.up * PlayerSpeed;
    }
}