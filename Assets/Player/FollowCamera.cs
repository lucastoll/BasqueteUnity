using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    void FixedUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPoisition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}
