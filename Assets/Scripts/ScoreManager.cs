using NUnit.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public GameObject pin1;
    public GameObject pin2;
    public GameObject pin3;
    public GameObject pin4;
    public GameObject pin5;
    public GameObject pin6;
    public GameObject pin7;
    public GameObject pin8;
    public GameObject pin9;
    public GameObject pin10;

    public GameObject ball;
    public TextMeshProUGUI ScoreText;
    public RawImage completed;
    public Button nextLvl;
    public Button retryLvl;
    public Button menuButton;
    public Button resetButton;
    private static int score;
    private static int hsLvl1;
    private static int hsLvl2;
    private static int hsLvl3;
    private static int hsLvl4;
    private static int hsLvl5;
    public Rigidbody rb;

    public bool scoreCalculated;
    void Start()
    {
        score = 0;
        scoreCalculated = false;
        HideLevelUI();
        hsLvl1 = 0;
    }
    void Update()
    {
        if (rb.transform.position.y < -100 && !scoreCalculated)
        {
            CalculateScore();
            ShowLevelUI();
        }

        if (score > hsLvl1)
        {
            hsLvl1 = score;
            PlayerPrefs.SetInt("best score", hsLvl1);
        }
    }


    public void CalculateScore()
    {
        if (pin1.transform.rotation.eulerAngles.x > 1 || pin1.transform.rotation.eulerAngles.x < -1 || pin1.transform.rotation.eulerAngles.z > 1 || pin1.transform.rotation.eulerAngles.z < -1)
        {
            score ++;
            Debug.Log("pin 1 hit");
        }
        if (pin2.transform.rotation.eulerAngles.x > 1 || pin2.transform.rotation.eulerAngles.x < -1 || pin2.transform.rotation.eulerAngles.z > 1 || pin2.transform.rotation.eulerAngles.x < -1)
        {
            score ++;
            Debug.Log("pin 2 hit");
        }
        if (pin3.transform.rotation.eulerAngles.x > 1 || pin3.transform.rotation.eulerAngles.x < -1 || pin3.transform.rotation.eulerAngles.z > 1 || pin3.transform.rotation.z < -1)
        {
            score ++;
            Debug.Log("pin 3 hit");
        }
        if (pin4.transform.rotation.eulerAngles.x > 1 || pin4.transform.rotation.eulerAngles.x < -1 || pin4.transform.rotation.eulerAngles.z > 1 || pin4.transform.rotation.z < -1)
        {
            score ++;
            Debug.Log("pin 4 hit");
        }
        if (pin5.transform.rotation.eulerAngles.x > 1 || pin5.transform.rotation.eulerAngles.x < -1 || pin5.transform.rotation.eulerAngles.z > 1 || pin5.transform.rotation.z < -1)
        {
            score ++;
            Debug.Log("pin 5 hit");
        }
        if (pin6.transform.rotation.eulerAngles.x > 1 || pin6.transform.rotation.eulerAngles.x < -1 || pin6.transform.rotation.eulerAngles.z > 1 || pin6.transform.rotation.z < -1)
        {
            score ++;
            Debug.Log("pin 6 hit");
        }
        if (pin7.transform.rotation.eulerAngles.x > 1 || pin7.transform.rotation.eulerAngles.x < -1 || pin7.transform.rotation.eulerAngles.z > 1 || pin7.transform.rotation.z < -1)
        {
            score ++;
            Debug.Log("pin 7 hit");
        }
        if (pin8.transform.rotation.eulerAngles.x > 1 || pin8.transform.rotation.eulerAngles.x < -1 || pin8.transform.rotation.eulerAngles.z > 1 || pin8.transform.rotation.z < -1)
        {
            score ++;
            Debug.Log("pin 8 hit");
        }
        if (pin9.transform.rotation.eulerAngles.x > 1 || pin9.transform.rotation.eulerAngles.x < -1 || pin9.transform.rotation.eulerAngles.z > 1 || pin9.transform.rotation.z < -1)
        {
            score ++;
            Debug.Log("pin 9 hit");
        }
        if (pin10.transform.rotation.eulerAngles.x > 1 || pin10.transform.rotation.eulerAngles.x < -1 || pin10.transform.rotation.eulerAngles.z > 1 || pin10.transform.rotation.z < -1)
        {
            score ++;
            Debug.Log("pin 10 hit");
        }

        ScoreText.text = "Score: " + score.ToString();
        scoreCalculated = true;
    }

    public void HideLevelUI()
    {
        ScoreText.enabled = false;
        completed.enabled = false;
        nextLvl.gameObject.SetActive(false);
        retryLvl.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
        resetButton.gameObject.SetActive(true);
    }

    public void ShowLevelUI()
    {
        ScoreText.enabled = true;
        completed.enabled = true;
        nextLvl.gameObject.SetActive(true);
        retryLvl.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
        resetButton.gameObject.SetActive(false);
    }

    public void SaveNumber()
    {
        PlayerPrefs.SetInt("best score", hsLvl1);
    }

    public void LoadNumber()
    {
        int loadedNumber = PlayerPrefs.GetInt("best score");
    }


}
