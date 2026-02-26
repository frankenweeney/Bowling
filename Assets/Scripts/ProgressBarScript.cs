using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ProgressBarScript : MonoBehaviour
{
    public static ProgressBarScript Instance { get; private set; }
    private float startTime = 0f;
    private float timer = 0f;
    public float holdTime = 4.0f;
    public Image progressBar;
    private bool held = false;
    public TextMeshProUGUI E;

    public string key = "e";

    private void Start()
    {
        progressBar.fillAmount = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            startTime = Time.time;
            timer = startTime;
        }

        if (Input.GetKey(key) && held == false)
        {
            timer += Time.deltaTime;
            progressBar.fillAmount += Time.deltaTime / holdTime;

            if (timer > (startTime + holdTime))
            {
                held = true;
                ButtonHeld();
                HideInteractDisplay();
            }
        }

        if (Input.GetKeyUp(key))
        {
            held = false;
            progressBar.fillAmount = 0;

        }
    }
        void ButtonHeld()
        {
            
        }
        public void HideInteractDisplay()
        {
            progressBar.enabled = false;
            E.enabled = false;
        }
}
