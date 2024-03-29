using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public event Action OnPlantChanged;

    private PlayerMain _main;

    public void Initialize(PlayerMain main)
    {
        _main = main;
    }

    [Serializable]
    public class InventorySlot
    {
        [field: SerializeField]
        public SO_Plants Plant { get; set; }

        [field: SerializeField]
        public int Amount { get; set; }
    }

    [SerializeField]
    private List<InventorySlot> _inventory = new ();

    private int _selectedIndex;

    // Méthode pour récupérer la Plante, qui est actuellement choisi, dans d'autres scripts
    public SO_Plants GetSelectedSeed()
    {
        return GetSelectedSlot().Plant;
    }

    // Méthode pour connaître l'index d'où se situe le joueur dans la liste
    public InventorySlot GetSelectedSlot()
    {
        return _inventory[_selectedIndex];
    }

    // Méthode pour connaître le nombre de graines de la plantes choisi
    public int GetSeedAmount()
    {
        return GetSelectedSlot().Amount;
    }

    // Méthode pour enlever le nombre de graines de la plantes choisi
    public void RemoveSeed()
    {
        if (GetSeedAmount() == 0)
        {
            return;
        }

        GetSelectedSlot().Amount--;
        _main.UIplant.ShowPlant();
    }

    // Méthode pour ajouter le nombre de graines de la plantes choisi
    public void AddSeed()
    {
        GetSelectedSlot().Amount++;
        _main.UIplant.ShowPlant();
    }

    private void Start()
    {
        // Récuper l'action quand la touche "c" est préssé
        _main.InputAction = _main.Input.actions.FindAction("ChangePlant");
        _main.UIplant.ShowPlant();
    }

    // Méthode pour pouvoir changer de Plantes
    private SO_Plants OnChangePlant()
    {
        _selectedIndex = (_selectedIndex + 1) % _inventory.Count;
        OnPlantChanged?.Invoke();
        return GetSelectedSlot().Plant;
    }
}
