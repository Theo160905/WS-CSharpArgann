using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    [Serializable]
    public class InventorySlot
    {
        [field: SerializeField]
        public SO_Plants Plant { get; set; }

        [field: SerializeField]
        public int Amount { get; set; }
    }

    [SerializeField]
    private List<InventorySlot> _inventory = new();

    private int _selectedIndex;

    PlayerInput _input;
    InputAction _ChangePlant;

    PlayerPlant _plant;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _ChangePlant = _input.actions.FindAction("ChangePlant");
        _plant = GetComponent<PlayerPlant>();
    }

    SO_Plants OnChangePlant()
    {
        _selectedIndex = (_selectedIndex + 1) % _inventory.Count;

        return GetSelectedSlot().Plant;
    }

    public SO_Plants GetSelectedSeed()
    {
        return GetSelectedSlot().Plant;
    }

    public InventorySlot GetSelectedSlot()
    {
        return _inventory[_selectedIndex];
    }

    public int GetSeedAmount()
    {
        return GetSelectedSlot().Amount;
    }

    public void RemoveSeed()
    {
        if (GetSeedAmount() == 0) return;

        GetSelectedSlot().Amount--;
    }

    public void AddSeed()
    {
        GetSelectedSlot().Amount++;
    }
}
