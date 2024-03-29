using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _speed = 5.0f;

    private PlayerMain _main;

    public void Initialize(PlayerMain main)
    {
        _main = main;
    }

    // Méthode pour que le joueur puisse bouger
    private void OnMove()
    {
        Vector2 direction = _main.Input.actions.FindAction("Move").ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, direction.y, 0) * Time.deltaTime * _speed;
    }

    private void FixedUpdate()
    {
        // La méthode OnMove() est mis dans un FixedUpdate pour que les movements du joueurs soient fluides
        OnMove();
    }
}
