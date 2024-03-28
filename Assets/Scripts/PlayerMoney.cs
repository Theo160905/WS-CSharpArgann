public class PlayerMoney : PlayerMain
{
    public int MoneyPlayer;

    //Méthode pour connaitre la valeur MoneyPlayer dans d'autres scripts
    public int GetMoneyPlayer()
    {
        return MoneyPlayer;
    }

    //Méthode pour retirer une valeur (money) au joueur
    public void RemoveMoney(int money)
    {
        if (GetMoneyPlayer() == 0) return;
        MoneyPlayer -= money;
    }

    //Méthode pour ajouter une valeur (money) au joueur
    public void AddMoney(int money)
    {
        MoneyPlayer += money;
    }
}
