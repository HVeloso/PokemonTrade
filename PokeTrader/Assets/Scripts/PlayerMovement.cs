using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 movementDirection = new(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        transform.position += _speed * Time.deltaTime * movementDirection;
    }

    private void OnValidate()
    {
        if (_speed < 0) _speed = 0;
    }
}
