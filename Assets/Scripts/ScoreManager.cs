using NUnit.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
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
    public int score;
    void Start()
    {
        score = 0;
    }
    void Update()
    {

    }

    public void CalculateScore()
    {
        if (pin1.transform.rotation.x > 1 || pin1.transform.rotation.x < -1 || pin1.transform.rotation.z > 1 || pin1.transform.rotation.z < -1)
        {
            score += 1;
        }
        if (pin2.transform.rotation.x > 1 || pin2.transform.rotation.x < -1 || pin2.transform.rotation.z > 1 || pin2.transform.rotation.z < -1)
        {
            score += 1;
        }
        if (pin3.transform.rotation.x > 1 || pin3.transform.rotation.x < -1 || pin3.transform.rotation.z > 1 || pin3.transform.rotation.z < -1)
        {
            score += 1;
        }
        if (pin4.transform.rotation.x > 1 || pin4.transform.rotation.x < -1 || pin4.transform.rotation.z > 1 || pin4.transform.rotation.z < -1)
        {
            score += 1;
        }
        if (pin5.transform.rotation.x > 1 || pin5.transform.rotation.x < -1 || pin5.transform.rotation.z > 1 || pin5.transform.rotation.z < -1)
        {
            score += 1;
        }
        if (pin6.transform.rotation.x > 1 || pin6.transform.rotation.x < -1 || pin6.transform.rotation.z > 1 || pin6.transform.rotation.z < -1)
        {
            score += 1;
        }
        if (pin7.transform.rotation.x > 1 || pin7.transform.rotation.x < -1 || pin7.transform.rotation.z > 1 || pin7.transform.rotation.z < -1)
        {
            score += 1;
        }
        if (pin8.transform.rotation.x > 1 || pin8.transform.rotation.x < -1 || pin8.transform.rotation.z > 1 || pin8.transform.rotation.z < -1)
        {
            score += 1;
        }
        if (pin9.transform.rotation.x > 1 || pin9.transform.rotation.x < -1 || pin9.transform.rotation.z > 1 || pin9.transform.rotation.z < -1)
        {
            score += 1;
        }
        if (pin10.transform.rotation.x > 1 || pin10.transform.rotation.x < -1 || pin10.transform.rotation.z > 1 || pin10.transform.rotation.z < -1)
        {
            score += 1;
        }

        ScoreText.text = "Score: " + score.ToString();
    }
}
