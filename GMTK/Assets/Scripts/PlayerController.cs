using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CharacterMovement();
    }

    void CharacterMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        float mass = rb.mass;
        float baseSpeed = speed;
        float calculatedSpeed = baseSpeed / mass;

        Vector3 movement = new Vector3(moveX, 0, moveZ).normalized * calculatedSpeed;
        movement.y = rb.velocity.y;
        rb.velocity = movement;
    }
}
