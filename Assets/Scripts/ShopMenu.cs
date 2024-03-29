using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject _panelshop;

    public void EnterShopPanel()
    {
        _panelshop.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ExitShopPanel()
    {
        _panelshop.SetActive(false);
        Time.timeScale = 1f;
    }
}
