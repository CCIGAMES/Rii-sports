using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Scenes/baseballField");
    }

    public void Settings()
    {
    }

    public void Dlcs()
    {
    }

    public void Quit()
    {
        Application.Quit();
    }
    //TODO: loading screen
    //private IEnumerator Play(){}
}