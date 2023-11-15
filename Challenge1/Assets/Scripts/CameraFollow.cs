using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform plane;
    private Vector3 offset;

    private void Start() => offset = Camera.main.transform.position;

    private void FixedUpdate() => transform.position = plane.transform.position + offset;
}
