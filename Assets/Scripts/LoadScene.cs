using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Script utilisé que pour les boutons pour pouvoir accéder une scene à l'autre
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadControllerScene()
    {
        SceneManager.LoadScene("ControllerScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
