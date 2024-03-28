using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPlant : MonoBehaviour
{
    private int _moneyplayer = 0;
    PlayerMoney _playerMoney;

    [SerializeField]
    private Inventory _inventory;

    PlayerInput _input;

    InputAction _plant;

    Plot _plot;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _plant = _input.actions.FindAction("Plant");
        _playerMoney = GetComponent<PlayerMoney>();
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

    void OnPlant()
    {
        if (_plot != null && _plot.Plant == null && _inventory.GetSeedAmount() > 0)
        {
            _inventory.RemoveSeed();
            _plot.PlantSeed(_inventory.GetSelectedSeed());
        }

        if (_plot != null && _plot.Plant != null)
        {
            _moneyplayer += _plot.GatherPlant();
            _playerMoney.AddMoney(_moneyplayer);
            _moneyplayer = 0;
        }
    }
}
