using TMPro;
using UnityEngine;

public class UIPlant : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _textplantselected;

    private PlayerMain _main;

    public void Initialize(PlayerMain main)
    {
        _main = main;
        _main.InventoryScript.OnPlantChanged += ShowPlant;
    }

    public void ShowPlant()
    {
        _textplantselected.SetText(_main.InventoryScript.GetSelectedSeed().name + " : " + _main.InventoryScript.GetSelectedSlot().Amount);
    }
}
