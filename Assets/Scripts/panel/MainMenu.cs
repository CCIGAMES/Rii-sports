using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.SceneManagement;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class MainMenu : MonoBehaviour
{
    private EventInstance theme;
    
    private void Awake()
    {
        theme = RuntimeManager.CreateInstance("event:/theme");
    }
    private void Start()
    {
        theme.start();
    }

    public void Play()
    {
        theme.stop(STOP_MODE.IMMEDIATE);
        SceneManager.LoadScene("Scenes/Baseball");
    }

    //TODO: settings menu
    //public void Settings(){}

    //TODO: DLC system 
    //public void Dlcs(){}

    public void Quit()
    {
        Application.Quit();
    }

    //TODO: loading screen
    //private IEnumerator Play(){}
}