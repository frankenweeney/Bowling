using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCameraScript : MonoBehaviour
{
    public Camera camera;
    public float rotationSpeed = 90;
    public float speed = 5f;

    [Header("UI Elements to Cycle Through")]
    public List<GameObject> uiElements; // Assign in Inspector

    [Header("Input Settings")]
    public KeyCode nextKey = KeyCode.RightArrow;
    public KeyCode prevKey = KeyCode.LeftArrow;
    public bool useMouseScroll = true;

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
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            if (inLvlSelection == false)
            {
                RotateCamera(-1);
            }

            if (inLvlSelection == true)
            {
                CyclePrevious();
            }
            
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (inLvlSelection == false)
            {
                RotateCamera(1);
            }

            if (inLvlSelection == true)
            {
                CycleNext();
            }

        }

        if ( Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        }
    }

    private void RotateCamera(int direction)
    {
        transform.Rotate(Vector3.up * direction * rotationSpeed * Time.deltaTime, Space.World);
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


