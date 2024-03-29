using TMPro;
using UnityEngine;

public class PlayerUI : PlayerMain
{
    [SerializeField]
    TextMeshProUGUI _textplantselected;

    [SerializeField]
    TextMeshProUGUI _textmoney;

    public void ShowPlant()
    {
        _textplantselected.SetText(_inventoryscript.GetSelectedSeed().name + " : " + _inventoryscript.GetSelectedSlot().Amount);
    }

    public void ShowMoney()
    {
        _textmoney.text = _money.MoneyPlayer.ToString();
    }
}
