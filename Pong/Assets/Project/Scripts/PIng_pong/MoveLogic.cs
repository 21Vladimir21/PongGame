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
        Move();
    }

    abstract public void Move();

}