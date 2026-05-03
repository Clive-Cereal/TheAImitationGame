using System;
using UnityEngine;
using UnityEngine.InputSystem;
using FMODUnity;

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
    
    [Header("Audio")]
    [SerializeField] private EventReference footstepEvent;
    [SerializeField] private EventReference jumpEvent;
    [SerializeField] private EventReference landEvent;

    [Header("Interaction")]
    [SerializeField] private float interactDistance = 5f;
    [SerializeField] private float interactRadius = 0.35f;
    [SerializeField] private LayerMask interactMask = ~0;

    private Interactable currentInteractable;
    private Interactable previousInteractable;
    private CharacterController cc;
    private float pitch;
    private Vector3 velocity;
    private bool inputEnabled = true;
    private bool _altPeeking;
    private bool _wasGrounded;
    private float _stepTimer;

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

        bool altHeld = Keyboard.current != null && Keyboard.current.altKey.isPressed;
        if (altHeld != _altPeeking)
        {
            _altPeeking      = altHeld;
            Cursor.lockState = altHeld ? CursorLockMode.None   : CursorLockMode.Locked;
            Cursor.visible   = altHeld;
        }

        if (!_altPeeking) Look();
        Move();
        UpdateCurrentInteractable();
    }

    public event Action OnPausePressed;
    public event Action OnTabletPressed;
    public event Action OnManualPressed;
    public event Action OnNotepadPressed;

    // ── Input System message callbacks ──────────────────────────────────────
    private void OnMove(InputValue value)   => moveInput = value.Get<Vector2>();
    private void OnLook(InputValue value)   => lookInput = value.Get<Vector2>();
    private void OnSprint(InputValue value) => sprinting = value.isPressed;
    private void OnPause(InputValue value)  => OnPausePressed?.Invoke();
    private void OnTablet(InputValue value) => OnTabletPressed?.Invoke();
    private void OnManual(InputValue value) => OnManualPressed?.Invoke();
    private void OnNotepad(InputValue value) => OnNotepadPressed?.Invoke();
    
    private void OnJump(InputValue value)
    {
        if (!inputEnabled || !cc.isGrounded) return;
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        RuntimeManager.PlayOneShot(jumpEvent, transform.position);
    }

    private void OnInteract(InputValue value)
    {
    if (!inputEnabled) return;
    if (!value.isPressed) return;

    if (currentInteractable != null)
    {
        currentInteractable.TryInteract();
    }
    }

    private void UpdateCurrentInteractable()
{
    previousInteractable = currentInteractable;
    currentInteractable = null;

    if (playerCamera == null) return;

    Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);

    RaycastHit[] hits = Physics.SphereCastAll(
        ray,
        interactRadius,
        interactDistance,
        interactMask,
        QueryTriggerInteraction.Collide
    );

    float closestDistance = Mathf.Infinity;

    foreach (RaycastHit hit in hits)
    {
        Interactable interactable = hit.collider.GetComponentInParent<Interactable>();

        if (interactable == null) continue;

        if (hit.distance < closestDistance)
        {
            closestDistance = hit.distance;
            currentInteractable = interactable;
        }
    }

    if (previousInteractable != currentInteractable)
    {
        SetInteractableHighlight(previousInteractable, false);
        previousInteractable?.OnFocusLost();
        SetInteractableHighlight(currentInteractable, true);
    }
}





private void SetInteractableHighlight(Interactable interactable, bool value)
{
    if (interactable == null) return;

    InteractableHighlighter highlighter =
        interactable.GetComponentInParent<InteractableHighlighter>();

    if (highlighter != null)
    {
        highlighter.SetHighlighted(value);
    }
}

private void OnDisable()
{
    SetInteractableHighlight(currentInteractable, false);
    currentInteractable = null;
    previousInteractable = null;
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
        bool grounded = cc.isGrounded;
        if (grounded && velocity.y < 0f) velocity.y = -2f;

        if (grounded && !_wasGrounded)
            RuntimeManager.PlayOneShot(landEvent, transform.position);
        _wasGrounded = grounded;

        Vector3 move = (transform.right * moveInput.x + transform.forward * moveInput.y).normalized;
        float speed  = moveSpeed * (sprinting ? sprintMultiplier : 1f);
        cc.Move(move * speed * Time.deltaTime);

        if (grounded && moveInput != Vector2.zero)
        {
            _stepTimer -= Time.deltaTime;
            if (_stepTimer <= 0f)
            {
                RuntimeManager.PlayOneShot(footstepEvent, transform.position);
                _stepTimer = sprinting ? 0.3f : 0.45f;
            }
        }
        else
        {
            _stepTimer = 0f;
        }

        velocity.y += gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
    }

    // ── Called by DayManager to disable input during UI review ──────────────
    public void SetInputEnabled(bool enabled)
    {
        inputEnabled     = enabled;
        _altPeeking      = false;
        Cursor.lockState = enabled ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible   = !enabled;
    }
}
