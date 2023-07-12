using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

abstract public class MoveLogic : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D PlayerRb;
    [SerializeField] protected float PlayerSpeed = 3;
    void Update()
    {
        if (Init.Instance.mobile == false)
            Move();
    }

    abstract public void Move();
    abstract public void MobileMoveUp();
    abstract public void MobileMoveDown();

}