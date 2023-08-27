using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject loadingScreen;
    public TMP_Text ProgressIndicator;
    public Image LoadingBar;

    private void Start()
    {
        AudioDB.themeMusic.start();
    }

    public void Play(string scene)
    {
        AudioDB.themeMusic.stop(STOP_MODE.IMMEDIATE);
        SceneManager.LoadScene("Scenes/Tennis");
        // mainMenu.SetActive(false);
        // loadingScreen.SetActive(true);
        // StartCoroutine(Load(scene));
    }

    //TODO: settings menu
    public void Settings(){}

    //TODO: DLC system 
    public void Dlcs(){}

    public void Quit()
    {
        Application.Quit();
    }

    /*private IEnumerator Load(string scene)
    {
        var operation = SceneManager.LoadSceneAsync(scene);
        
        while (!operation.isDone)
        {
            var progress = Mathf.Clamp01(operation.progress);
            Debug.Log(progress);
            LoadingBar.fillAmount = progress;
            ProgressIndicator.text = progress * 100 / .9f + "%";

            yield return null;
        }

        if (operation.isDone)
            if (GameObject.Find("LoadingScreen") == true)
                active = true;
            else
                active = false;
        if (active)
            loadingScreen.SetActive(false);
    }*/
}