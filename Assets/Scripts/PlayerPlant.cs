﻿using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPlant : MonoBehaviour
{
    public int MoneyPlayer = 0;

    [SerializeField]
    private Inventory _inventory;

    PlayerInput _input;

    InputAction _plant;

    Plot _plot;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _plant = _input.actions.FindAction("Plant");
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
        if (_plot != null && _plot.Plant == null && _inventory.GetSeedNb() != 0)
        {
            _plot.PlantSeed(_inventory.GetSelectedSeed());
        }

        if (_plot != null && _plot.Plant != null)
        {
            MoneyPlayer += _plot.GatherPlant();
        }
    }
}
