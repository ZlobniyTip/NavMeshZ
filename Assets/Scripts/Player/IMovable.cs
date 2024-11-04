using UnityEngine;

public interface IMovable
{
    public MoveType MoveType { get; }
    public float Speed { get; }
    public void Move();
}