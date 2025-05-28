using UnityEngine;

public class PlayerJump : MonoBehaviour
{
	public float horizontalDirection;
	public float speed;
	public float jumpForce;

	private float _horizontalDirection;
	private Rigidbody2D _rigidbody2D;
	public LayerMask groundLayer;
	private bool _isGrounded;
	public Transform groundCheckPosition;
	public float groundCheckRadius;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		horizontalDirection = Input.GetAxisRaw("Horizontal");

		transform.position = new Vector2(transform.position.x + horizontalDirection * speed * Time.deltaTime, transform.position.y);
		_rigidbody2D.linearVelocityX = _horizontalDirection * speed;

		if (Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, groundLayer))
		{
			_isGrounded = true;
		}
		else {
			_isGrounded = false;
		}

		if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
		{
			_rigidbody2D.AddForceY(jumpForce, ForceMode2D.Impulse);
		}

	}

	private void onDrawGlizmos()
	{
		Gizmos.DrawWireSphere(groundCheckPosition.position, groundCheckRadius);
	}
}
