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
    public AudioBehaviour music;

    public List<GameObject> uiElements;
    private int currentIndex = 0;
    public TextMeshProUGUI level;
    public TextMeshProUGUI name;
    public RawImage leftArrow;
    public RawImage rightArrow;
    public RawImage levelSelect;

    public bool inLvlSelection;
    public bool inBallSelection;
    public bool centered;
    public bool atCounter;
    public bool atDoor;

    public Vector3 center = new Vector3 (-3.45f, 2.34f, -7.78f);
    public Vector3 front = new Vector3(-5, 3, -1);
    public Vector3 left = new Vector3();
    public Vector3 horse = new Vector3();
    public Vector3 door = new Vector3();


    public Cursor cursor;

    void Start()
    {
        Cursor.visible = false;
        centered = true;
        inLvlSelection = false;
        inBallSelection = false;
        levelSelect.enabled = false;
        atCounter = false;
        atDoor = false;

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
           leftArrow.color = Color.white;

        }

        if (Input.GetKey(KeyCode.RightArrow) && centered == true)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            rightArrow.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) && centered == true)
        {
            leftArrow.color = default;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && centered == true)
        {
            rightArrow.color = default;
        }


        if (transform.rotation.eulerAngles.y > -45 && transform.rotation.eulerAngles.y < 45 && centered == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                inLvlSelection = true;
                transform.position = (front);
            }
        }
        if (transform.rotation.eulerAngles.y > 255 && transform.rotation.eulerAngles.y < 285 && centered == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                inBallSelection = true;
                transform.position = (left);
            }
        }
        if (transform.rotation.eulerAngles.y > 200 && transform.rotation.eulerAngles.y < 228 && centered == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position = (horse);
                atCounter = true;
            }
        }
        if (transform.rotation.eulerAngles.y > 140 && transform.rotation.eulerAngles.y < 160 && centered == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position = (door);
                atDoor = true;
            }
        }

        if (inLvlSelection == true)
        {
            uiElements[currentIndex].SetActive(true);
            centered = false;
            level.enabled = true;
            levelSelect.enabled = true;

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
                uiElements[currentIndex].SetActive(false);
                level.enabled = false;
                levelSelect.enabled = false;
                MoveToCenter();
            }

            if (currentIndex == 0)
            {
                level.text = "Level 1";
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    SceneManager.LoadScene("LevelOne");
                }
            }
            if (currentIndex == 1)
            {
                level.text = "Level 2";
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    SceneManager.LoadScene("LevelTwo");
                }
            }
            if (currentIndex == 2)
            {
                level.text = "Level 3";
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    SceneManager.LoadScene("LevelThree");
                }
            }
            if (currentIndex == 3)
            {
                level.text = "Level 4";
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    SceneManager.LoadScene("LevelFour");
                }
            }
            if (currentIndex == 4)
            {
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
            leftArrow.enabled = false;
            rightArrow.enabled = false;
            centered = false;

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MoveToCenter();
            }
        }

        if (atCounter == true)
        {
            centered = false;
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MoveToCenter();
            }
        }

        if (atDoor == true)
        {
            centered = false;
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MoveToCenter();
            }
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
        transform.position = (center);
        leftArrow.enabled = true;
        rightArrow.enabled = true;
        inBallSelection = false;
        inLvlSelection = false;
        atCounter = false;
        atDoor = false;
        name.enabled = false;
    }
}


