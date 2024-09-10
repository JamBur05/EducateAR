using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{

    public RectTransform mainMenu, helpMenu, downloadMenu;

    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero, 0.35f);
    }

    public void OpenHelpMenu()
    {
        mainMenu.DOAnchorPos(new Vector2(-2036, 0), 0.35f);
        helpMenu.DOAnchorPos(new Vector2(0, 0), 0.35f);
    }

    public void CloseHelpMenu()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.35f);
        helpMenu.DOAnchorPos(new Vector2(2036, 0), 0.35f);
    }

    public void OpenDownloadMenu()
    {
        mainMenu.DOAnchorPos(new Vector2(-2036, 0), 0.35f);
        downloadMenu.DOAnchorPos(new Vector2(0, -60), 0.35f);
    }

    public void CloseDownloadMenu()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.35f);
        downloadMenu.DOAnchorPos(new Vector2(0, 2382), 0.30f);
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
