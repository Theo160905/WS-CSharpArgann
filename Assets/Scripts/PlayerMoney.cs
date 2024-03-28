using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    Inventory _inventory;
    Plot _plot;

    private void Start()
    {
        _inventory = GetComponent<Inventory>();
    }
    public int MoneyPlayer;
    public int GetMoneyPlayer()
    {
        return MoneyPlayer;
    }

    public void RemoveMoney(int money)
    {
        if (GetMoneyPlayer() == 0) return;
        MoneyPlayer -= money;
    }

    public void AddMoney(int money)
    {
        MoneyPlayer += money;
    }
}
