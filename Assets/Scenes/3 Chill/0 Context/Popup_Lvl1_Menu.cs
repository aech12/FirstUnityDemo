using UnityEngine;
using UnityEngine.SceneManagement;

public class Popup_Lvl1_Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject lvlStartMenuUI;

    public void CloseMenu()
    {
        lvlStartMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void OpenMenu()
    {
        lvlStartMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void StartLvl1()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
