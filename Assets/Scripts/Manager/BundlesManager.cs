using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BundlesManager : MonoBehaviour
{
    public GameObject loadingScreen;
    public Image loadingBar;
    public TMP_Text loadingText;
    public GameObject mainMenu;

    private Loading loading;

    private void Awake()
    {
        loading = loadingBar.GetComponent<Loading>();
    }
}
