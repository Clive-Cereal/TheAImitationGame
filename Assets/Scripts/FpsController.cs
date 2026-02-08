using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FpsController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform cameraRoot; // vertical rotate the camera. 
    [SerializeField] private Camera playerCamera;

    [Header("Look")]
    [SerializeField] private float mouseSensitivity = 2.0f;
    [SerializeField] private float pitchMin = -80f;
    [SerializeField] private float pitchMax = 80f;

    [Header("Move")]
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float sprintMultiplier = 1.6f;
    [SerializeField] private float jumpHeight = 1.2f;
    [SerializeField] private float gravity = -20f;

    [Header("Ground Check")]
    [SerializeField] private float groundedStickForce = -2f; 

    private CharacterController cc;
    private float pitch;
    private Vector3 velocity;

    private void Awake()
    {
        cc = GetComponent<CharacterController>();

        if (playerCamera == null) playerCamera = Camera.main;
        if (cameraRoot == null && playerCamera != null) cameraRoot = playerCamera.transform.parent;

        LockCursor(true);
    }

    private void Update()
    {
        Look();
        Move();
    }

    private void Look()
    {
        float mx = Input.GetAxisRaw("Mouse X") * mouseSensitivity;
        float my = Input.GetAxisRaw("Mouse Y") * mouseSensitivity;

        // horizontal: player rotate
        transform.Rotate(Vector3.up * mx);

        // vertical: camera rotate
        pitch -= my;
        pitch = Mathf.Clamp(pitch, pitchMin, pitchMax);

        if (cameraRoot != null)
            cameraRoot.localRotation = Quaternion.Euler(pitch, 0f, 0f);
        else if (playerCamera != null)
            playerCamera.transform.localRotation = Quaternion.Euler(pitch, 0f, 0f);
    }

    private void Move()
    {
        // grounded check
        bool grounded = cc.isGrounded;

        if (grounded && velocity.y < 0f)
            velocity.y = groundedStickForce;

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = (transform.right * x + transform.forward * z).normalized;

        float speed = moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift)) speed *= sprintMultiplier;

        cc.Move(move * speed * Time.deltaTime);

        if (grounded && Input.GetButtonDown("Jump"))
        {
            // v = sqrt(2gh) 
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
    }

    public void LockCursor(bool locked)
    {
        Cursor.lockState = locked ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !locked;
    }
}
