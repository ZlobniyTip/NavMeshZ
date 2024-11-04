using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();

    }

    private void Update()
    {
        SetupAnimation(_playerMovement.Movable.Speed);
    }

    private void SetupAnimation(float speed)
    {
        _animator.SetFloat(Params.Speed, Mathf.Abs(speed));
    }
}

public class Params
{
    public static readonly int Speed = Animator.StringToHash(nameof(Speed));
}