using UnityEngine;

public class PlayerPlant : PlayerMain
{
    private int _moneyplayer = 0;

    private void Start()
    {
        _inputaction = _input.actions.FindAction("Plant");       
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

    //Méthode qui permet au joueur de mettre une plantes sur un "plot" (zone où le joueur pose les plantes)
    void OnPlant()
    {
        if (_plot != null && _plot.Plant == null && _inventoryscript.GetSeedAmount() > 0)
        {
            _inventoryscript.RemoveSeed();
            _playerUI.ShowPlant();
            _plot.PlantSeed(_inventoryscript.GetSelectedSeed());
        }

        if (_plot != null && _plot.Plant != null)
        {
            _moneyplayer += _plot.GatherPlant();
            _money.AddMoney(_moneyplayer);
            _moneyplayer = 0;
        }
    }
}
