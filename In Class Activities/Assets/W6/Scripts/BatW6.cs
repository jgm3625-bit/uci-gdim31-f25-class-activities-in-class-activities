using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody _rb;
    private bool _isChasing;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, _speed);
    }
        public void EnableChase(Transform playerTransform)
    {
        _playerTransform = playerTransform;
        _isChasing = true;
        _animator.SetBool("isMoving", true);
    }

    public void DisableChase()
    {
        _isChasing = false;
        _rb.linearVelocity = Vector3.zero;
        _animator.SetBool("isMoving", false);
    }
}
