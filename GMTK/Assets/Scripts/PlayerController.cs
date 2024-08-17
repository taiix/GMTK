using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float mouseSensitivity;

    private Rigidbody rb;
    private Camera cam;

    private float cameraYrotation = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    void Update()
    {
        CharacterMovement();
        CharacterRotation();
    }

    void CharacterMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 forward = cam.transform.forward;
        Vector3 right = cam.transform.right;

        forward.y = 0f;
        right.y = 0f;

        Vector3 desiredMoveDirection = (forward * moveZ + right * moveX).normalized;

        Vector3 movement = desiredMoveDirection * speed;

        movement.y = rb.velocity.y;

        rb.velocity = movement;
    }

    void CharacterRotation() { 
        float xRot = Input.GetAxis("Mouse X") * mouseSensitivity;
        float yRot = Input.GetAxis("Mouse Y") * mouseSensitivity;


        cameraYrotation -= yRot;
       
        cameraYrotation = Mathf.Clamp(cameraYrotation, -90f, 90f);

        cam.transform.localEulerAngles = Vector3.right * cameraYrotation;
        transform.Rotate(Vector3.up * xRot);
    }
}
