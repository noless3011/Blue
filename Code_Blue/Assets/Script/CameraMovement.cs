using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothness = 0.5f;
    public Vector3 offset ;
    void FixedUpdate()
    {
        Vector3 desirePos = target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(target.position, desirePos, smoothness);
        transform.position = smoothedPos;
    }
}
