using TMPro;
using UnityEngine;

public class UIMoney : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI _textmoney;

    private PlayerMain _main;

    public void Initialize(PlayerMain main)
    {
        _main = main;
        _main.Money.OnMoneyChanged += ShowMoney;
    }


    public void ShowMoney()
    {
        _textmoney.text = _main.Money.MoneyPlayer.ToString();
    }
}
