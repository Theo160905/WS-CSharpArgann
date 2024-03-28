using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRecup : MonoBehaviour
{
    public int MoneyPlayer=0;

    [SerializeField]
    private Inventory _inventory;

    PlayerInput _input;

    InputAction _recup;

    Plot _plot;

    private GameObject _gameObject;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _recup = _input.actions.FindAction("Recup");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plot")
        {
            _plot = collision.gameObject.GetComponent<Plot>();
        };
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plot")
        {
            _plot = null;
        }
    }

    void OnRecup()
    {
        if (_plot != null && _plot.Plant != null)
        {
            MoneyPlayer += _plot.GatherPlant();
        }
    }
}
