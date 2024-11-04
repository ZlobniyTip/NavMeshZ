using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class NavMeshMovement : IMovable
{
    private NavMeshAgent _navMeshAgent;
    private Camera _camera;

    public MoveType MoveType { get; private set; } = MoveType.NavMesh;

    public float Speed => _navMeshAgent.speed;

    [Inject]
    private void Construct(PlayerComponents playerComponents)
    {
        _camera = Camera.main;
        _navMeshAgent = playerComponents.NavMeshAgent;
    }

    public void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out hit))
                _navMeshAgent.SetDestination(hit.point);
        }
    }
}