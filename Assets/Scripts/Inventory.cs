using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : PlayerMain
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

    private void Start()
    {
        //Récuper l'action quand la touche "c" est préssé
        _inputaction = _input.actions.FindAction("ChangePlant");
    }

    //Méthode pour pouvoir changer de Plantes 
    SO_Plants OnChangePlant()
    {
        _selectedIndex = (_selectedIndex + 1) % _inventory.Count;

        return GetSelectedSlot().Plant;
    }

    //Méthode pour récupérer la Plante, qui est actuellement choisi, dans d'autres scripts 
    public SO_Plants GetSelectedSeed()
    {
        return GetSelectedSlot().Plant;
    }

    //Méthode pour connaître l'index d'où se situe le joueur dans la liste
    public InventorySlot GetSelectedSlot()
    {
        return _inventory[_selectedIndex];
    }

    //Méthode pour connaître le nombre de graines de la plantes choisi
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
