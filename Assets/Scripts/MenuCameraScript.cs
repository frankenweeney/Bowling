using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuCameraScript : MonoBehaviour
{
    public Camera camera;
    public float rotationSpeed = 90;
    public float speed = 90f;

    public List<GameObject> uiElements;
    private int currentIndex = 0;
    public TextMeshProUGUI level;

    public bool inLvlSelection;
    public bool inBallSelection;
    public bool centered;

    public Vector3 center = new Vector3 (0, 2.34f, -7.78f);
    public Vector3 front = new Vector3(-5, 3, -1);

    void Start()
    {
        Cursor.visible = false;
        centered = true;
        inLvlSelection = false;
        inBallSelection = false;

        if (uiElements == null || uiElements.Count == 0)
        {
            Debug.LogError("UI Elements list is empty!");
            enabled = false;
            return;
        }

        ShowOnlyCurrent();

        uiElements[currentIndex].SetActive(false);
        level.enabled = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && centered == true)
        {
           transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) && centered == true)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }


        if (transform.rotation.eulerAngles.y > 315 || transform.rotation.eulerAngles.y < 45 && centered == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                inLvlSelection = true;
                transform.position = Vector3.MoveTowards(transform.position, front, speed * Time.deltaTime);
            }
        }
        if (transform.rotation.eulerAngles.y > 45 || transform.rotation.eulerAngles.y < 135 && centered == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                inBallSelection = true;
            }
        }

        if (inLvlSelection == true)
        {
            uiElements[currentIndex].SetActive(true);
            centered = false;

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                CyclePrevious();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                CycleNext();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                inLvlSelection = false;
                uiElements[currentIndex].SetActive(false);
                level.enabled = false;
                MoveToCenter();
            }

            if (currentIndex == 0)
            {
                level.enabled = true;
                level.text = "Level 1";
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    SceneManager.LoadScene("LevelOne");
                }
            }
            if (currentIndex == 1)
            {
                level.enabled = true;
                level.text = "Level 2";
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    SceneManager.LoadScene("LevelTwo");
                }
            }
            if (currentIndex == 2)
            {
                level.enabled = true;
                level.text = "Level 3";
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    SceneManager.LoadScene("LevelThree");
                }
            }
            if (currentIndex == 3)
            {
                level.enabled = true;
                level.text = "Level 4";
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    SceneManager.LoadScene("LevelFour");
                }
            }
            if (currentIndex == 4)
            {
                level.enabled = true;
                level.text = "Level 5";
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    SceneManager.LoadScene("LevelFive");
                }
            }

        }

        if (inBallSelection == true)
        {
            Cursor.visible = true;
        }
    }


    void CycleNext()
    {
        currentIndex = (currentIndex + 1) % uiElements.Count;
        ShowOnlyCurrent();
    }

    void CyclePrevious()
    {
        currentIndex = (currentIndex - 1 + uiElements.Count) % uiElements.Count;
        ShowOnlyCurrent();
    }

    void ShowOnlyCurrent()
    {
        for (int i = 0; i < uiElements.Count; i++)
        {
            uiElements[i].SetActive(i == currentIndex);
        }
    }
    void MoveToCenter()
    {
        centered = true;
        transform.position = Vector3.MoveTowards(transform.position, center, speed * Time.deltaTime);
    }
}


