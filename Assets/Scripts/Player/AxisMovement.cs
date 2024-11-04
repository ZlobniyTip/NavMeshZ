using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody))]
public class AxisMovement : IMovable
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    private Transform _transform;
    private Rigidbody _rigidbody;

    public MoveType MoveType { get; private set; } = MoveType.Axis;

    public float Speed => _rigidbody.velocity.magnitude;

    [Inject]
    private void Construct(PlayerComponents playerComponents)
    {
        _transform = playerComponents.Transform;
        _rigidbody = playerComponents.Rigidbody;
    }

    public void Move()
    {
        float horizontal = Input.GetAxis(HorizontalAxis);
        float vertical = Input.GetAxis(VerticalAxis);

        _transform.position = new Vector3(horizontal, 0 , vertical);
    }
}