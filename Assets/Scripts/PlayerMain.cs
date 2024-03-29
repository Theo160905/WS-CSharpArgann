using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMain : MonoBehaviour
{
    /// <summary>
    /// Liens envers chaque script du joueur
    /// </summary>
    public PlayerPlant Playerplant;

    public PlayerMovement Movement;

    public Inventory InventoryScript;

    public Plot Plot;

    public UIPlant UIplant;

    public UIMoney UImoney;

    public PlayerInput Input;

    public InputAction InputAction;

    public PlayerMoney Money { get; private set; }

    private void Awake()
    {
        Input = GetComponent<PlayerInput>();
        Money = GetComponent<PlayerMoney>();
        Money.Initialize(this);
        Movement = GetComponent<PlayerMovement>();
        Movement.Initialize(this);
        InventoryScript = GetComponent<Inventory>();
        InventoryScript.Initialize(this);
        UIplant = GetComponent<UIPlant>();
        UIplant.Initialize(this);
        UImoney = GetComponent<UIMoney>();
        UImoney.Initialize(this);
        Playerplant = GetComponent<PlayerPlant>();
        Playerplant.Initialize(this);
        Plot = GetComponent<Plot>();
    }
}
