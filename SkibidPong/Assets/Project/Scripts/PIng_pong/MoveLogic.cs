using Kimicu.YandexGames;
using UnityEngine;

abstract public class MoveLogic : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D PlayerRb;
    [SerializeField] protected float PlayerSpeed = 3;
    void Update()
    {
        if (Device.IsMobile == false)
            Move();
    }

    abstract public void Move();
    abstract public void MobileMoveUp();
    abstract public void MobileMoveDown();

}