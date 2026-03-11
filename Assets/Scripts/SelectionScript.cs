using TMPro;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{

    public float moveSpeed = 2f;
    private Renderer objRenderer;
    private Color originalColor;
    public Color hoverColor = Color.yellow;
    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        if (objRenderer != null)
        {
            originalColor = objRenderer.material.color;
        }
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        if (objRenderer != null)
        {
            objRenderer.material.color = hoverColor;
        }
    }

    private void OnMouseExit()
    {
        if (objRenderer != null)
        {
            objRenderer.material.color = originalColor;
        }
    }

    public void OnMouseDown()
    {
        if (gameObject.name == "gorillaz")
        {
            PlayerPrefs.SetInt("ballNumber", 1);
        }
        if (gameObject.name == "leon")
        {
            PlayerPrefs.SetInt("ballNumber", 2);
        }
        if (gameObject.name == "minecraft")
        {
            PlayerPrefs.SetInt("ballNumber", 3);
        }
        if (gameObject.name == "regular")
        {
            PlayerPrefs.SetInt("ballNumber", 4);
        }
        if (gameObject.name == "swag")
        {
            PlayerPrefs.SetInt("ballNumber", 5);
        }
        if (gameObject.name == "twinpeaks")
        {
            PlayerPrefs.SetInt("ballNumber", 6);
        }
        if (gameObject.name == "ball7")
        {
            PlayerPrefs.SetInt("ballNumber", 7);
        }
        if (gameObject.name == "ball8")
        {
            PlayerPrefs.SetInt("ballNumber", 8);
        }
        PlayerPrefs.Save();
    }

    
}
