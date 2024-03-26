using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerInput _input;

    InputAction _movement;

    private float _speed = 5.0f;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _movement = _input.actions.FindAction("Move");
    }
    private void FixedUpdate()
    {
        OnMove();
    }

    void OnMove()
    {
        Vector2 direction = _movement.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, direction.y, 0) * Time.deltaTime * _speed;
    }
}
