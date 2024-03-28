using UnityEngine;

public class PlayerMovement : PlayerMain
{
    private float _speed = 5.0f;

    private void Start()
    {
        //Récuper l'action quand les touches "zqsd" ou que les flèches directionnelles sont préssées
        _inputaction = _input.actions.FindAction("Move");
    }

    //Méthode pour que le joueur puisse bouger
    void OnMove()
    {
        Vector2 direction = _inputaction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, direction.y, 0) * Time.deltaTime * _speed;
    }

    private void FixedUpdate()
    {
        //La méthode OnMove() est mis dans un FixedUpdate pour que les movements du joueurs soient fluides
        OnMove();
    }
}
