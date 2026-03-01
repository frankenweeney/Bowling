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

    public int score;
    public bool hasRun;
    void Start()
    {
        hasRun = false;
    }
    void Update()
    {
       if (ball.transform.position.y < -4 && hasRun == false)
       {
         CalculateScore();
         hasRun = true;
       }
    }

    public void CalculateScore()
    {
        if (pin1.transform.rotation.eulerAngles.x != 0 || pin1.transform.rotation.eulerAngles.z != 0)
        {
            score += 1;
        }

        if (pin2.transform.rotation.eulerAngles.x != 0 || pin2.transform.rotation.eulerAngles.z != 0)
        {
            score += 1;
        }

        if (pin3.transform.rotation.eulerAngles.x != 0 || pin3.transform.rotation.eulerAngles.z != 0)
        {
            score += 1;
        }

        if (pin4.transform.rotation.eulerAngles.x != 0 || pin4.transform.rotation.eulerAngles.z != 0)
        {
            score += 1;
        }

        if (pin5.transform.rotation.eulerAngles.x != 0 || pin5.transform.rotation.eulerAngles.z != 0)
        {
            score += 1;
        }

        if (pin6.transform.rotation.eulerAngles.x != 0 || pin6.transform.rotation.eulerAngles.z != 0)
        {
            score += 1;
        }

        if (pin7.transform.rotation.eulerAngles.x != 0 || pin7.transform.rotation.eulerAngles.z != 0)
        {
            score += 1;
        }

        if (pin8.transform.rotation.eulerAngles.x != 0 || pin8.transform.rotation.eulerAngles.z != 0)
        {
            score += 1;
        }

        if (pin9.transform.rotation.eulerAngles.x != 0 || pin9.transform.rotation.eulerAngles.z != 0)
        {
            score += 1;
        }

        if (pin10.transform.rotation.eulerAngles.x != 0 || pin10.transform.rotation.eulerAngles.z != 0)
        {
            score += 1;
        }
    }
}
