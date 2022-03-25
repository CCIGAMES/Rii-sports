using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Scenes/baseballField");
    }

    public void Settings() { }

    public void Dlcs() { }

    public void Quit()
    {
        Application.Quit();
    }
    
    private IEnumerator Play(){}
}
