using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryV2 : MonoBehaviour
{
    public List<SO_Plants> plantsList;
    public List<int> inventorySlots;

    PlayerInput _input;

    InputAction _ChangePlant;

    private int _indexplantslist = 0;


    private void Start()
    {
        //_input = GetComponent<PlayerInput>();
        //_ChangePlant = _input.actions.FindAction("ChangePlant");
        for (int i = 0; i < plantsList.Count; i++ )
        {
            inventorySlots.Add(0);
        }
    }

    SO_Plants OnChangePlant()
    {
        _indexplantslist++;
        if (_indexplantslist == plantsList.Count)
        {
            _indexplantslist = 0;
        }

        return plantsList[_indexplantslist];
    }

    public SO_Plants GetSelectedSeed()
    {
        return plantsList[_indexplantslist];
    }
}

