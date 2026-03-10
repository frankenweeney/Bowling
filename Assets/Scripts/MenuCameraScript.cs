using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCameraScript : MonoBehaviour
{
    public Camera camera;
    public float rotationSpeed = 90;
    public float speed = 5f;

    public List<GameObject> uiElements;
    private int currentIndex = 0;

    public bool inLvlSelection;

    void Start()
    {
        inLvlSelection = false;

        if (uiElements == null || uiElements.Count == 0)
        {
            Debug.LogError("UI Elements list is empty!");
            enabled = false;
            return;
        }

        ShowOnlyCurrent();

        uiElements[currentIndex].SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && inLvlSelection == false)
        {
           transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) && inLvlSelection == false)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

    


        if (camera.transform.rotation.eulerAngles.y > -45 && camera.transform.rotation.eulerAngles.y < 45)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                inLvlSelection = true;
            }
        }

        if (inLvlSelection == true)
        {
            uiElements[currentIndex].SetActive(true);

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
}


