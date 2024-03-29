using System;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public event Action OnMoneyChanged;

    public int MoneyPlayer { get; private set; }

    private PlayerMain _main;

    public void Initialize(PlayerMain main)
    {
        _main = main;
    }

    // Méthode pour retirer une valeur (money) au joueur
    public void RemoveMoney(int money)
    {
        if (MoneyPlayer == 0)
        {
            return;
        }

        MoneyPlayer -= money;
        OnMoneyChanged?.Invoke();
    }

    // Méthode pour ajouter une valeur (money) au joueur
    public void AddMoney(int money)
    {
        MoneyPlayer += money;
        _main.UImoney.ShowMoney();
    }
}
