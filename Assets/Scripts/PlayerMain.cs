using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMain : MonoBehaviour
{
    /// <summary>
    /// Liens envers chaque script
    /// </summary>
    protected PlayerPlant _playeplant;
    protected PlayerMovement _movement;
    protected PlayerMoney _money;
    protected Inventory _inventoryscript;
    protected Plot _plot;

    protected PlayerInput _input;
    protected InputAction _inputaction;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _money = GetComponent<PlayerMoney>();
        _movement = GetComponent<PlayerMovement>();
        _money = GetComponent<PlayerMoney>();
        _inventoryscript = GetComponent<Inventory>();
    }
}
