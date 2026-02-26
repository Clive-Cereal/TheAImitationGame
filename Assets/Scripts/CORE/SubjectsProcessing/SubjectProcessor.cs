using UnityEngine;
using System;

public class SubjectProcessor : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float rotationSpeed = 8f;
    [SerializeField] private float arrivalThreshold = 0.05f;

    private Vector3 targetPosition;
    private bool isMoving;
    private Action onArrived;

    private void Update()
    {
        if (!isMoving) return;

        Vector3 direction = targetPosition - transform.position;
        float distance = direction.magnitude;

        if (distance < arrivalThreshold)
        {
            transform.position = targetPosition;
            isMoving = false;

            // Clear before invoking to prevent re-entry
            Action callback = onArrived;
            onArrived = null;
            callback?.Invoke();
            return;
        }

        // Rotate to face movement direction (ignore Y axis)
        Vector3 flatDirection = new Vector3(direction.x, 0f, direction.z).normalized;
        if (flatDirection != Vector3.zero)
        {
            Quaternion targetRot = Quaternion.LookRotation(flatDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    public void MoveTo(Vector3 destination, Action callback = null)
    {
        targetPosition = destination;
        onArrived      = callback;
        isMoving       = true;
    }

    public void LeaveAndDestroy(Vector3 exitPoint)
    {
        MoveTo(exitPoint, () => Destroy(gameObject));
    }
}
