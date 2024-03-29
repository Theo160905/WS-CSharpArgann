using UnityEngine;

public class Dealer : MonoBehaviour
{
    [SerializeField]
    private Inventory _inventory;

    [SerializeField]
    private PlayerMoney _money;

    [SerializeField]
    private ShopMenu _shopmenu;

    public void BuySeed()
    {
        // Vérifier si le joueur a assez de thunes
        if (_money.MoneyPlayer >= _inventory.GetSelectedSeed().BuyValue)
        {
            // Si c'est le cas, tu enlève de l'argent au joueur, et tu lui ajoutes une graine.
            _money.RemoveMoney(_inventory.GetSelectedSeed().BuyValue);
            _inventory.AddSeed();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _shopmenu.EnterShopPanel();
        }
    }
}
