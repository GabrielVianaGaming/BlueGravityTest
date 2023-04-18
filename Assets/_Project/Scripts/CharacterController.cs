using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private static readonly int Walk = Animator.StringToHash("walk");

    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private Animator _animatorCharacter;

    private bool _facingRight = true;
    private bool _isMovementEnabled = true;
    private Rigidbody2D _rb;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animatorCharacter = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (_isMovementEnabled)
        {
            var horizontalMovement = Input.GetAxis("Horizontal");
            var verticalMovement = Input.GetAxis("Vertical");

            _rb.velocity = new Vector2(horizontalMovement * _moveSpeed, verticalMovement * _moveSpeed);

            _animatorCharacter.SetBool(Walk, false);

            if (Mathf.Abs(_rb.velocity.magnitude) > 0.01f) _animatorCharacter.SetBool(Walk, true);

            if ((horizontalMovement > 0 && !_facingRight) || (horizontalMovement < 0 && _facingRight)) Flip();
        }
    }

    private void Flip()
    {
        var transformCharacter = transform;
        var scale = transformCharacter.localScale;
        
        _facingRight = !_facingRight;
        scale.x *= -1;
        transformCharacter.localScale = scale;
    }

    public void EnableMovement() => _isMovementEnabled = true;

    public void DisableMovement() => _isMovementEnabled = false;
    
}
