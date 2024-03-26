using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    public List<SO_Plants> plantsList;

    PlayerInput _input;

    InputAction _ChangePlant;

    private int _indexplantslist = 0 ;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _ChangePlant = _input.actions.FindAction("ChangePlant");
        Debug.Log(plantsList[_indexplantslist].Name);
    }

    SO_Plants OnChangePlant()
    {
        _indexplantslist++;
        if (_indexplantslist == plantsList.Count)
        {
            _indexplantslist = 0 ;
        }
        Debug.Log(plantsList[_indexplantslist].Name);

        return plantsList[_indexplantslist];
    }
}
