using TMPro;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{

    public float moveSpeed = 2f;
    private Renderer objRenderer;
    private Color originalColor;
    public Color hoverColor = Color.yellow;
    public TextMeshProUGUI name;
    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        if (objRenderer != null)
        {
            originalColor = objRenderer.material.color;
        }
        name.enabled = false;
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        name.enabled = true;

        if (gameObject.name == "gorillaz")
        {
            name.text = "gorillaz";
        }
        if (gameObject.name == "leon")
        {
            name.text = "leon kennedy";
        }
        if (gameObject.name == "minecraft")
        {
            name.text = "minecraft";
        }
        if (gameObject.name == "regular")
        {;
            name.text = "default";
        }
        if (gameObject.name == "swag")
        {
            name.text = "SWAG";
        }
        if (gameObject.name == "twinpeaks")
        {
            name.text = "twin peaks";
        }
        if (gameObject.name == "ball7")
        {
            name.text = "idk";
        }
        if (gameObject.name == "ball8")
        {
            name.text = "idk";
        }

        if (objRenderer != null)
        {
            objRenderer.material.color = hoverColor;
            transform.localScale =  new Vector3(3, 3, 3);
        }
    }

    private void OnMouseExit()
    {
        if (objRenderer != null)
        {
            objRenderer.material.color = originalColor;
            transform.localScale = new Vector3(2.546261f, 2.546261f, 2.546261f);
        }
        name.enabled = false;
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

        gameObject.SetActive(false);
    }

    
}
