using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(5, 20)]
    [SerializeField] private float speed = 15;

    private const float rotationSpeed = 2;
    private float verticalInput = 0;

    private void Update() => verticalInput = Input.GetAxis("Vertical");

    private void FixedUpdate()
    {
        transform.Translate(CalculateTranslate());
        transform.Rotate(CalculateRotate());
    }

    private Vector3 CalculateTranslate() => Vector3.forward *speed * Time.fixedDeltaTime;

    private Vector3 CalculateRotate() => Vector3.left * verticalInput * -rotationSpeed;
}