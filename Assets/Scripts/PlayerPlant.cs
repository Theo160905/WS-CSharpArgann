using UnityEngine;

public class PlayerPlant : MonoBehaviour
{
    private int MoneyPlayer { get; set; }

    private PlayerMain _main;

    public void Initialize(PlayerMain main)
    {
        _main = main;
    }

    private void Start()
    {
        _main.InputAction = _main.Input.actions.FindAction("Plant");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plot")
        {
            _main.Plot = collision.gameObject.GetComponent<Plot>();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plot")
        {
            _main.Plot = null;
        }
    }

    // Méthode qui permet au joueur de mettre une plantes sur un "plot" (zone où le joueur pose les plantes)
    private void OnPlant()
    {
        if (_main.Plot != null && _main.Plot.Plant == null && _main.InventoryScript.GetSeedAmount() > 0)
        {
            _main.InventoryScript.RemoveSeed();
            _main.UIplant.ShowPlant();
            _main.Plot.PlantSeed(_main.InventoryScript.GetSelectedSeed());
        }

        if (_main.Plot != null && _main.Plot.Plant != null)
        {
            MoneyPlayer += _main.Plot.GatherPlant();
            _main.Money.AddMoney(MoneyPlayer);
            MoneyPlayer = 0;
        }
    }
}
