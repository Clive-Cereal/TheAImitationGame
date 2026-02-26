using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController), typeof(PlayerInput))]
public class PlayerController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Camera playerCamera;

    [Header("Look")]
    [SerializeField] private float mouseSensitivity = 0.2f;
    [SerializeField] private float pitchMin = -80f;
    [SerializeField] private float pitchMax = 80f;

    [Header("Move")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float sprintMultiplier = 1.6f;
    [SerializeField] private float jumpHeight = 1.2f;
    [SerializeField] private float gravity = -20f;

    private CharacterController cc;
    private float pitch;
    private Vector3 velocity;
    private bool inputEnabled = true;

    private Vector2 moveInput;
    private Vector2 lookInput;
    private bool sprinting;

    private void Awake()
    {
        cc = GetComponent<CharacterController>();
        if (playerCamera == null) playerCamera = Camera.main;
        SetInputEnabled(true);
    }

    private void Update()
    {
        if (!inputEnabled) return;
        Look();
        Move();
    }

    // ── Input System message callbacks ──────────────────────────────────────
    private void OnMove(InputValue value)   => moveInput = value.Get<Vector2>();
    private void OnLook(InputValue value)   => lookInput = value.Get<Vector2>();
    private void OnSprint(InputValue value) => sprinting = value.isPressed;

    private void OnJump(InputValue value)
    {
        if (!inputEnabled || !cc.isGrounded) return;
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }

    private void OnInteract(InputValue value)
    {
        if (!inputEnabled) return;
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, 5f))
            hit.collider.GetComponent<Interactable>()?.TryInteract();
    }

    // ── Movement & look ─────────────────────────────────────────────────────
    private void Look()
    {
        transform.Rotate(Vector3.up * lookInput.x * mouseSensitivity);
        pitch -= lookInput.y * mouseSensitivity;
        pitch  = Mathf.Clamp(pitch, pitchMin, pitchMax);
        playerCamera.transform.localRotation = Quaternion.Euler(pitch, 0f, 0f);
    }

    private void Move()
    {
        if (cc.isGrounded && velocity.y < 0f) velocity.y = -2f;

        Vector3 move = (transform.right * moveInput.x + transform.forward * moveInput.y).normalized;
        float speed  = moveSpeed * (sprinting ? sprintMultiplier : 1f);
        cc.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
    }

    // ── Called by DayManager to disable input during UI review ──────────────
    public void SetInputEnabled(bool enabled)
    {
        inputEnabled     = enabled;
        Cursor.lockState = enabled ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible   = !enabled;
    }
}
