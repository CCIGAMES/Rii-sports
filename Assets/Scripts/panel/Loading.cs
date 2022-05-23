using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public TMP_Text ProgressIndicator;
    public Image LoadingBar;
    public float speed;
    private float currentValue;
    
    private void Update()
    {
        if (currentValue < 100)
        {
            currentValue += speed * Time.deltaTime;
            ProgressIndicator.text = ((int) currentValue) + "%";
        }
        else
        {
            ProgressIndicator.text = "Done";
        }

        LoadingBar.fillAmount = currentValue / 100;
    }
}