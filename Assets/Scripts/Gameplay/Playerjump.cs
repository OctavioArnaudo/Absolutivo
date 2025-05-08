using UnityEngine;

public class PlayerJump : MonoBehaviour
{
	public float horizontalDirection;
	public float speed;
	public float jumpForce;
	private Rigidbody2D _rigidbody2D;

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

		if (Input.GetKeyDown(KeyCode.Space))
		{
			//_rigidbody2D.AddForceY(jumpForce, VectorMode2D.Impulse));
		}

	}
}
