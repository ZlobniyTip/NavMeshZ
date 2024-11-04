using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class PlayerMovement : MonoBehaviour
{
    private IMovable _movable;
    private NavMeshAgent _navMeshAgent;
    private Rigidbody _rigidbody;

    public float Speed => _navMeshAgent.speed;

    public IMovable Movable => _movable;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _movable.Move();
    }

    [Inject]
    private void Construct(IMovable movable)
    {
        _movable = movable;
    }
}