using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject _panelshop;

    // Méthode pour afficher le panel pour acheter des gaines et stopper l'action du joueur
    public void EnterShopPanel()
    {
        _panelshop.SetActive(true);
        Time.timeScale = 0f;
    }

    // Méthode pour quitter le panel et que le joueur puisse bouger à nouveau
    public void ExitShopPanel()
    {
        _panelshop.SetActive(false);
        Time.timeScale = 1f;
    }
}
